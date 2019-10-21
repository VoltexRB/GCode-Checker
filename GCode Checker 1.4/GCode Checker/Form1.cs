using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCode_Checker
{
    public partial class Form1 : Form
    {
        bool cancel = false;
        bool relative = false;
        int positionIndex = 1;
        int line = 0;
        WarningDialogue[] Dialogues;
        string presetPath = "presets.txt";
        System.Windows.Point currentPos = new System.Windows.Point(0, 0);
        System.Windows.Point addedHome = new System.Windows.Point(0, 0);
        bool M500Found = false;
        bool inchUnits = false;
        bool homed = false;
        bool homeAfterM410 = false;
        int QuickstopLine = 0;
        int EEPROMLine = 0;
        bool WarningSent = false;
        int G1Messages = 0;
        public Form1()
        {
            Dialogues = new WarningDialogue[300];
            InitializeComponent();
        }

        private void BT_OPEN_Click(object sender, EventArgs e)
        {
            OF_GCODE.ShowDialog();
        }

        private void CB_BED_CheckedChanged(object sender, EventArgs e)
        {
            TB_HOTEND_TEMP.Enabled = CB_BED.Checked;
            TB_BED_TEMP.Enabled = CB_BED.Checked;
            TB_BEDX.Enabled = CB_BED.Checked;
            TB_BEDY.Enabled = CB_BED.Checked;
            RB_BED_CENTER.Enabled = CB_BED.Checked;
            RB_BED_BL.Enabled = CB_BED.Checked;
            CB_BED.ForeColor = Color.Black;
            RB_BED_BL.Checked = true;
        }

        private void OF_GCODE_FileOk(object sender, CancelEventArgs e)
        {
            TB_PATH.Text = OF_GCODE.FileName;
            BT_GO.Enabled = true;
        }

        private void CB_ALL_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in PA_SETTINGS.Controls)
            {
                if (control.Name.StartsWith("CB") && control.Name != "CB_M500" && (CB_ALL.CheckState == CheckState.Checked || CB_ALL.CheckState == CheckState.Unchecked))
                {
                    CheckBox current = control as CheckBox;
                    current.Checked = CB_ALL.Checked;
                }
            }
        }

        private void CB_ALL_Click(object sender, EventArgs e)
        {
            CB_ALL.Checked = !CB_ALL.Checked;
        }

        private void BT_GO_Click(object sender, EventArgs e)
        {
            CB_BED.ForeColor = Color.Black;
            if (CB_BED.Checked)
            {
                int dummy;
                if (!Int32.TryParse(TB_HOTEND_TEMP.Text, out dummy))
                {
                    CB_BED.ForeColor = Color.Maroon;
                    return;
                }
                if (!Int32.TryParse(TB_BED_TEMP.Text, out dummy))
                {
                    CB_BED.ForeColor = Color.Maroon;
                    return;
                }
                if (!Int32.TryParse(TB_BEDX.Text, out dummy))
                {
                    CB_BED.ForeColor = Color.Maroon;
                    return;
                }
                if (!Int32.TryParse(TB_BEDY.Text, out dummy))
                {
                    CB_BED.ForeColor = Color.Maroon;
                    return;
                }
            }
            for (int i = 0; i < 300; i++)
            {
                if (Dialogues[i] != null)
                {
                    Dialogues[i].Dispose();
                    Dialogues[i] = null;
                }
            }

            if (WarningSent)
            {
                StartSearchThread();
            }
            else if (Int32.Parse(TB_BEDY.Text) < 100 || Int32.Parse(TB_BEDX.Text) < 100 || Int32.Parse(TB_BED_TEMP.Text) < 50 || Int32.Parse(TB_HOTEND_TEMP.Text) < 150)
            {
                WarningSent = true;
                Dialogues[positionIndex] = new WarningDialogue("Tool settings seem low, this could lead to many messages. Continue -> Retry", "ER1", 2, line, positionIndex, this);

            }
            else
            {
                StartSearchThread();
            }

        }
        private void StartSearchThread()
        {
            foreach (Control control in PA_SETTINGS.Controls)
            {
                control.Enabled = false;
            }
            currentPos = new System.Windows.Point(0, 0);
            addedHome = new System.Windows.Point(0, 0);
            inchUnits = false;
            homed = false;
            homeAfterM410 = false;
            QuickstopLine = 0;
            G1Messages = 0;
            relative = false;
            cancel = false;
            positionIndex = 1;
            line = 0;
            M500Found = false;
            EEPROMLine = 0;
            BT_ABORT.Enabled = true;
            BT_GO.Enabled = false;
            TB_BEDY.Enabled = false;
            TB_BEDX.Enabled = false;
            TB_BED_TEMP.Enabled = false;
            TB_HOTEND_TEMP.Enabled = false;
            CB_BED.Enabled = false;
            CB_ALL.Enabled = false;
            BT_OPEN.Enabled = false;
            WarningSent = false;
            PA_RESULT.AutoScroll = false;
            new Thread(SearchMethod).Start();
        }

        private void BT_ABORT_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        void SearchMethod()
        {
            using (FileStream fs = new FileStream(OF_GCODE.FileName, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream && !cancel)
                    {
                        if (positionIndex == 200 || G1Messages > 50)
                        {
                            Dialogues[299] = new WarningDialogue("Too Many Errors! Wrong settings?", "0000", 4, line, 299, this);
                            for (int i = 1; i < Dialogues.Length-2; i++)
                            {
                                if (Dialogues[i] != null)
                                {
                                    Dialogues[i].SlideDown(); 
                                }
                            }
                            positionIndex = 0;
                            break;
                        }
                        string currentLine = sr.ReadLine();
                        line++;

                        if (!currentLine.StartsWith(";"))
                        {
                            if (currentLine.StartsWith("G28 ;") || currentLine == "G28")
                            {
                                if (QuickstopLine != 0 && !homeAfterM410)
                                {
                                    homeAfterM410 = true;
                                }
                                homed = true;
                            }
                            if (CB_BED.Checked && currentLine.StartsWith("M190"))
                            {
                                int value;
                                Int32.TryParse(currentLine.Substring(currentLine.IndexOf("S") + 1), out value);
                                if (value > Convert.ToInt32(TB_BED_TEMP.Text))
                                {
                                    Dialogues[positionIndex] = new WarningDialogue("Bed Temperature Exceeds Set Temperature", "M190", 2, line, positionIndex, this);
                                    positionIndex++;
                                }
                            }
                            if (CB_BED.Checked && currentLine.StartsWith("M104"))
                            {
                                int value;
                                Int32.TryParse(currentLine.Substring(currentLine.IndexOf("S") + 1), out value);
                                if (value > Convert.ToInt32(TB_HOTEND_TEMP.Text))
                                {
                                    Dialogues[positionIndex] = new WarningDialogue("Hotend Temperature Exceeds Set Temperature", "M104", 2, line, positionIndex, this);
                                    positionIndex++;
                                }
                            } 
                            if (CB_BED.Checked && currentLine.StartsWith("G1 ") && currentLine.Contains("E") && currentLine.Contains("X") && currentLine.Contains ("Y"))
                            {
                                if (!homed)
                                {
                                    Dialogues[positionIndex] = new WarningDialogue("Tried Moving without Homing!", "G1", 0, line, positionIndex, this);
                                    homed = true;
                                    positionIndex++;
                                }
                                currentLine = currentLine.Replace(".", ",");
                                double posX;
                                double posY;
                                Double.TryParse(currentLine.Substring(currentLine.IndexOf("X")+1, Math.Abs(currentLine.IndexOf("X") - currentLine.IndexOf("Y"))-1), out posX);
                                Double.TryParse(currentLine.Substring(currentLine.IndexOf("Y")+1, Math.Abs(currentLine.IndexOf("Y") - currentLine.IndexOf("E"))-1), out posY);
                                if (relative)
                                {
                                    currentPos.X += posX;
                                    currentPos.Y += posY;
                                }
                                else
                                {
                                    currentPos.X = posX;
                                    currentPos.Y = posY;
                                    currentPos.Y += addedHome.Y;
                                    currentPos.X += addedHome.X;
                                }
                                if (inchUnits)
                                {
                                    currentPos.X *= 2.54f;
                                    currentPos.Y *= 2.54f;
                                }

                                if (RB_BED_BL.Checked)
                                {
                                    if (currentPos.X < 0 || currentPos.Y > Convert.ToInt32(TB_BEDX.Text))
                                    {
                                        G1Messages++;
                                        Dialogues[positionIndex] = new WarningDialogue("Head moves out of Bounds in X", "G1", 1, line, positionIndex, this);
                                        positionIndex++;
                                    }
                                    if (currentPos.Y < 0 || currentPos.Y > Convert.ToInt32(TB_BEDY.Text))
                                    {
                                        G1Messages++;
                                        Dialogues[positionIndex] = new WarningDialogue("Head moves out of Bounds in Y", "G1", 1, line, positionIndex, this);
                                        positionIndex++;
                                    }
                                }
                                else
                                {
                                    if (currentPos.X < -Convert.ToInt32(TB_BEDX.Text) /2 || currentPos.X > Convert.ToInt32(TB_BEDX.Text) /2)
                                    {
                                        Dialogues[positionIndex] = new WarningDialogue("Head moves out of Bounds in X", "G1", 1, line, positionIndex, this);
                                        positionIndex++;
                                    }
                                    if (currentPos.Y < -Convert.ToInt32(TB_BEDY.Text) / 2 || currentPos.X > Convert.ToInt32(TB_BEDY.Text) / 2)
                                    {
                                        Dialogues[positionIndex] = new WarningDialogue("Head moves out of Bounds in Y", "G1", 1, line, positionIndex, this);
                                        positionIndex++;
                                    }
                                }
                            }
                            if (currentLine.StartsWith("M500"))
                            {
                                M500Found = true;
                                EEPROMLine = line;
                            }
                            if (CB_M502.Checked && currentLine.StartsWith("M502"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("EEPROM Settings are Factory Reset!", "M502", 0, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M906.Checked && (currentLine.StartsWith("M906") || currentLine.StartsWith("M907")))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Stepper Motor amperage is changed!", "M906/7", 0, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_G20.Checked && currentLine.StartsWith("G20"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Units are changed to Inches. Boundary check no longer possible", "G20", 2, line, positionIndex, this);
                                inchUnits = true;
                                positionIndex++;
                            }
                            if (CB_G91.Checked && currentLine.StartsWith("G91"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Positioning is set to relative. Boundary check no longer possible", "G91", 2, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M92.Checked && currentLine.StartsWith("M92"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("E-Steps are changed. Boundary check no longer possible", "M92", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M110.Checked && currentLine.StartsWith("M110"))
                            {
                                int lineNumber = Int32.Parse(currentLine.Substring(currentLine.IndexOf("N")+1));
                                if (lineNumber < line)
                                {
                                    Dialogues[positionIndex] = new WarningDialogue("Goes to a previous line. Infinite Loop expected", "M110", 2, line, positionIndex, this);
                                    positionIndex++;
                                }
                            }
                            if (CB_M149.Checked && currentLine.StartsWith("M149"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Temperature changed to a different Scale", "M149", 2, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M203.Checked && currentLine.StartsWith("M203"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Maximum Feedrate changed to: " + currentLine.Substring(currentLine.IndexOf("M203") + 5), "M203", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M201.Checked && currentLine.StartsWith("M201"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Maximum Acceleration changed to: " + currentLine.Substring(currentLine.IndexOf("M201") + 5), "M201", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M206.Checked && currentLine.StartsWith("M206"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Home offsets changed: " + currentLine.Substring(currentLine.IndexOf("M206")+5), "M206", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M211.Checked && currentLine.StartsWith("M211"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Enables virtual Software endstops", "M211", 2, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M220.Checked && currentLine.StartsWith("M220"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Changes Flowrate to: " + currentLine.Substring(currentLine.IndexOf("S")+1) + "%", "M220", 2, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M301.Checked && currentLine.StartsWith("M301"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Manual Hotend PID Tune: " + currentLine.Substring(currentLine.IndexOf("M301") + 5), "M301", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M302.Checked && currentLine.StartsWith("M302"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Minimum Extrude Temperature changed to: " + currentLine.Substring(currentLine.IndexOf("S") + 1), "M302", 2, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M303.Checked && currentLine.StartsWith("M303"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("PID Autotune Start", "M303", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M304.Checked && currentLine.StartsWith("M304"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Manual Heatbed PID Tune: " + currentLine.Substring(currentLine.IndexOf("M304") + 5), "M304", 1, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M350.Checked && currentLine.StartsWith("M350"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Microsteps changed for X_MS1 or Y_MS1 pins", "M350", 2, line, positionIndex, this);
                                positionIndex++;
                            }
                            if (CB_M401.Checked && currentLine.StartsWith("M401"))
                            {
                                if (line > 50)
                                {
                                    Dialogues[positionIndex] = new WarningDialogue("ABL Probe deployed mid-print!", "M401", 0, line, positionIndex, this);
                                    positionIndex++;
                                }
                            }
                            if (CB_M428.Checked && currentLine.StartsWith("M428"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Homeposition set Mid-Print! Highly unusual for normal slicers", "M428", 0, line, positionIndex, this);
                                addedHome.X = currentPos.X;
                                addedHome.Y = currentPos.Y;
                                positionIndex++;
                            }
                            if (CB_M410.Checked && currentLine.StartsWith("M410"))
                            {
                                Dialogues[positionIndex] = new WarningDialogue("Quickstop triggered. Position has to be homed again. Resume will result in failure", "M410", 2, line, positionIndex, this);
                                QuickstopLine = line;
                                homeAfterM410 = false;
                                positionIndex++;
                            }


                            if (QuickstopLine != 0 && line == QuickstopLine + 10 && !homeAfterM410)
                            {
                                Dialogues[positionIndex] = new WarningDialogue("No Home in 10 Lines after the Quickstop!", "M410", 0, line, positionIndex, this);
                                positionIndex++;
                            }
                        }
                    }
                    if (M500Found)
                    {
                        Dialogues[0] = new WarningDialogue("Some Settings are Saved to EEPROM!", "M500", 0, EEPROMLine, 0, this);
                    }
                    else
                    {
                        Dialogues[0] = new WarningDialogue("No EEPROM-Save detected", "M500", 3, line, 0, this);
                    }
                    cancel = false;
                    this.Invoke((MethodInvoker)delegate
                    {
                        BT_GO.Enabled = true;
                        BT_ABORT.Enabled = false;
                        TB_BEDY.Enabled = true;
                        TB_BEDX.Enabled = true;
                        TB_BED_TEMP.Enabled = true;
                        TB_HOTEND_TEMP.Enabled = true;
                        CB_BED.Enabled = true;
                        CB_ALL.Enabled = true;
                        BT_OPEN.Enabled = true;
                        PA_RESULT.AutoScroll = true;
                        foreach (Control control in PA_SETTINGS.Controls)
                        {
                            control.Enabled = true;
                        }
                    });
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BT_ABORT.Enabled)
            {
                e.Cancel = true;
                return;
            }
            using (FileStream fs = new FileStream(presetPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("X" + ":" + TB_BEDX.Text);
                    sw.WriteLine("Y" + ":" + TB_BEDY.Text);
                    sw.WriteLine("Bed" + ":" + TB_BED_TEMP.Text);
                    sw.WriteLine("Head" + ":" + TB_HOTEND_TEMP.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(presetPath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("X")) TB_BEDX.Text = line.Substring(line.IndexOf(":") + 1);
                        if (line.StartsWith("Y")) TB_BEDY.Text = line.Substring(line.IndexOf(":") + 1);
                        if (line.StartsWith("Bed")) TB_BED_TEMP.Text = line.Substring(line.IndexOf(":") + 1);
                        if (line.StartsWith("Head")) TB_HOTEND_TEMP.Text = line.Substring(line.IndexOf(":") + 1);
                    }
                }
            }
        }

        private void TB_Values_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox value = sender as TextBox;
            KeysConverter ks = new KeysConverter();
            Keys[] numberKeys = { Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9};
            foreach (Keys key in numberKeys)
            {
                if (e.KeyCode == key && value.TextLength <3)
                {
                    int selectionValue = value.SelectionStart;
                    value.Text = value.Text.Insert(value.SelectionStart, ks.ConvertToString(e.KeyCode));
                    if (value.Text.Contains("NumPad")) value.Text = value.Text.Replace("NumPad", "");
                    value.SelectionStart = selectionValue+1;
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                if (value.Text != "" && value.SelectionStart != 0)
                {
                    int selectionValue = value.SelectionStart;
                    value.Text = value.Text.Remove(value.SelectionStart - 1, 1);
                    value.SelectionStart = selectionValue-1;
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (value.Text != "" && value.SelectionStart != value.TextLength)
                {
                    int selectionValue = value.SelectionStart;
                    value.Text = value.Text.Remove(value.SelectionStart, 1);
                    value.SelectionStart = selectionValue; 
                }
            }
        }

        private void BT_OVERRIDE_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(presetPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("X" + ":" + TB_BEDX.Text);
                    sw.WriteLine("Y" + ":" + TB_BEDY.Text);
                    sw.WriteLine("Bed" + ":" + TB_BED_TEMP.Text);
                    sw.WriteLine("Head" + ":" + TB_HOTEND_TEMP.Text);
                }
            }
        }
    }


    class WarningDialogue
    {
        Panel Dialog;
        Label Gcode;
        Label Message;
        Label Line;
        Form1 TopLevelForm;
        int positionIndex = 0;
        public WarningDialogue(string _message, string _gcode, int relevancy,int _line, int PositionIndex, Form1 _TopLevelForm)
        {
            TopLevelForm = _TopLevelForm;
            positionIndex = PositionIndex;
            Dialog = new Panel
            {
                Width = 430,
                Height = 70,
                BorderStyle = BorderStyle.FixedSingle
            };
            if (PositionIndex != 299)
            {
                Dialog.Location = new Point(3, 2 + PositionIndex * 75);
            }
            else
            {
                Dialog.Location = new Point(3, 77);
            }
            if (relevancy == 0) Dialog.BackColor = Color.LightCoral;
            if (relevancy == 1) Dialog.BackColor = Color.FromArgb(255, 255, 192);
            if (relevancy == 2) Dialog.BackColor = Color.White;
            if (relevancy == 3) Dialog.BackColor = Color.PaleGreen;
            if (relevancy == 4)
            {
                Dialog.BackColor = Color.Black;
                Dialog.ForeColor = Color.White;
            }
            Gcode = new Label
            {
                Text = _gcode,
                Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold),
                Parent = Dialog,
                Location = new Point(2, 2)
            };
            Message = new Label
            {
                Text = _message,
                Font = new Font("Microsoft Sans Serif", 13),
                Parent = Dialog,
                Location = new Point(2, 20),
                Size = new Size(400, 50)
            };
            Line = new Label
            {
                Text = "Line: " + _line.ToString(),
                Font = new Font("Microsoft Sans Serif", 9),
                Parent = Dialog,
                Location = new Point(100, 2),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            Dialog.Controls.Add(Line);
            Dialog.Controls.Add(Gcode);
            Dialog.Controls.Add(Message);
            TopLevelForm.Invoke((MethodInvoker)delegate { TopLevelForm.PA_RESULT.Controls.Add(Dialog); });
        }

        public void SlideDown()
        {
            if (positionIndex != 299)
            {
                TopLevelForm.Invoke((MethodInvoker)delegate
            {
                Dialog.Location = new Point(Dialog.Location.X, Dialog.Location.Y + 75);
            }); 
            }
        }
        public void Dispose()
        {
            TopLevelForm.Invoke((MethodInvoker)delegate
            {
                Gcode.Dispose();
                Message.Dispose();
                Line.Dispose();
                Dialog.Dispose();
            });
        }
    }
}
