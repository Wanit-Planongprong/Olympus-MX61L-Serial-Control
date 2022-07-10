using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Olympus_MX61_MX61L_Serial_comm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            getAvalablePorts();
        }
        /// <summary>
        /// Get Avalable serial port
        /// </summary>
        void getAvalablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comport_list.Items.AddRange(ports);
            comport_light.Items.AddRange(ports);
        }

        /// <summary>
        /// Connect serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(comport_list.Text=="" || combo_parity.Text =="")
                {
                    richTextBox_recieve.Text = "Please select port setting";
                    
                 }
                else
                {
                    serialPort1.PortName = comport_list.Text;
                    serialPort1.BaudRate = 19200;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), combo_parity.Text);
                    //serialPort1.Parity = Parity.Even;
                    serialPort1.StopBits = StopBits.Two;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    send_btn.Enabled = true;
                    Text_Command.Enabled = true;
                    richTextBox_recieve.Enabled = true;
                    open_btn.Enabled = false;
                    close_btn.Enabled = true;
                    Remote.Enabled = true;
                    Local.Enabled = true;
                    comport_list.Enabled = false;
                    combo_parity.Enabled = false;
                    Thread.Sleep(500);
                    WriteSerial(MX61_MX61L_Command.LoginState);
                    Thread.Sleep(500);
                    WriteSerial(MX61_MX61L_Command.LoginState);
                    Thread.Sleep(500);
                    WriteSerial(MX61_MX61L_Command.LoginState);
                }
            }
            catch (UnauthorizedAccessException)
            {
                richTextBox_recieve.Text = "Unauthorized Access";
            }
        }
        /// <summary>
        /// Close Serial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_btn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            send_btn.Enabled = false;
            Text_Command.Enabled = false;
            richTextBox_recieve.Enabled = true;
            open_btn.Enabled = true;
            close_btn.Enabled = false;
            comport_list.Enabled = true;
            combo_parity.Enabled = true;
            Remote.Enabled = false;
            Local.Enabled = false;

        }
        /// <summary>
        /// Send command via command line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_btn_Click(object sender, EventArgs e)
        {
            WriteSerial(Text_Command.Text);
            sending_comand(Text_Command.Text);
            Text_Command.Text = "";
            
        }
        /// <summary>
        /// Monitor command sending
        /// </summary>
        /// <param name="COMMAND"></param>
        private void sending_comand(string COMMAND)
        {
            richTextBox_recieve.AppendText($"Sending: {COMMAND}\r\n");
            
        }
        /// <summary>
        /// Callback Serial return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                send_state.Checked = true;
                Handle_Serial_Rrturn(serialPort1.ReadLine());
                //richTextBox_recieve.Text = "Recieved: ";
                
            }
            catch(Exception EX)
            {
                richTextBox_recieve.Text = "Timeout Exception";
                
            }
        }

        /// <summary>
        /// Handle Serial return for machine state
        /// </summary>
        /// <param name="RETURN"></param>
        private void Handle_Serial_Rrturn (string RETURN)
        {
            send_state.Checked = false;
            richTextBox_recieve.AppendText($"Recieved: {RETURN}");
            string A = RETURN.Replace("\r","");

            //string[] subA = A.Split(' ');
            char[] charSeparators = new char[] { ' ' };
            string[] result;
            result = A.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            string Command_return = result[0];
            string Command_result = result[1];
            //richTextBox_recieve.AppendText($"Split String: {Command_return}\r\n");
                
            switch (Command_return)
            {
                case "1LOG":
                    if(Command_result == "IN")
                    {
                        WriteSerial(MX61_MX61L_Command.ObjectivePos);
                        sending_comand(MX61_MX61L_Command.ObjectivePos);
                        WriteSerial(MX61_MX61L_Command.Unit_presence);
                        sending_comand(MX61_MX61L_Command.Unit_presence);
                        WriteSerial(MX61_MX61L_Command.Cube_Status);
                        sending_comand(MX61_MX61L_Command.Cube_Status);
                        WriteSerial(MX61_MX61L_Command.Gare_Prevent_State);
                        sending_comand(MX61_MX61L_Command.Gare_Prevent_State);
                        Remote.Enabled = false;
                        Local.Enabled = true;
                        Pos1.Enabled = true;
                        Pos2.Enabled = true;
                        Pos3.Enabled = true;
                        Pos4.Enabled = true;
                        Pos5.Enabled = true;
                        ob_as1.Enabled = true;
                        ob_as2.Enabled = true;
                        ob_as3.Enabled = true;
                        ob_as4.Enabled = true;
                        ob_as5.Enabled = true;
                        cube_state.Enabled = true;
                        Unit_presence.Enabled = true;
                        gare_prevent_on.Enabled = true;
                        gare_prevent_off.Enabled = true;
                        gare_state.Enabled = true;
                       
                    }
                    if(Command_result == "OUT")
                    {
                        Remote.Enabled = true;
                        Local.Enabled = false;
                        Pos1.Enabled = false;
                        Pos2.Enabled = false;
                        Pos3.Enabled = false;
                        Pos4.Enabled = false;
                        Pos5.Enabled = false;
                        ob_as1.Enabled = false;
                        ob_as2.Enabled = false;
                        ob_as3.Enabled = false;
                        ob_as4.Enabled = false;
                        ob_as5.Enabled = false;
                        cube_state.Enabled = false;
                        Unit_presence.Enabled = false;
                        gare_prevent_on.Enabled = false;
                        gare_prevent_off.Enabled = false;
                        gare_state.Enabled = false;
                    }
                    break;
                case "1OB":
                    if(Command_result != "+")
                    {
                        switch (Command_result)
                        {
                            case "1":
                                textBox_Obj.Text = "5x";
                                textBox1.Text = "5x";
                                Pos1.Enabled = false;
                                Pos2.Enabled = true;
                                Pos3.Enabled = true;
                                Pos4.Enabled = true;
                                Pos5.Enabled = true;
                               
                                break;
                            case "2":
                                textBox_Obj.Text = "10x";
                                textBox1.Text = "10x";
                                Pos1.Enabled = true;
                                Pos2.Enabled = false;
                                Pos3.Enabled = true;
                                Pos4.Enabled = true;
                                Pos5.Enabled = true;
                               
                                break;
                            case "3":
                                textBox_Obj.Text = "20x";
                                textBox1.Text = "20x";
                                Pos1.Enabled = true;
                                Pos2.Enabled = true;
                                Pos3.Enabled = false;
                                Pos4.Enabled = true;
                                Pos5.Enabled = true;

                                break;
                            case "4":
                                textBox_Obj.Text = "50x";
                                textBox1.Text = "50x";
                                Pos1.Enabled = true;
                                Pos2.Enabled = true;
                                Pos3.Enabled = true;
                                Pos4.Enabled = false;
                                Pos5.Enabled = true;
                                
                                break;
                            case "5":
                                textBox_Obj.Text = "100x";
                                textBox1.Text = "100x";
                                Pos1.Enabled = true;
                                Pos2.Enabled = true;
                                Pos3.Enabled = true;
                                Pos4.Enabled = true;
                                Pos5.Enabled = false;
                                break;

                        }
                    }
                    break;
                case "1OBA":
                    if(Command_result == "1")
                    {
                        cube_inform.Text = "Brightfield or optional";
                    }
                    if (Command_result == "2")
                    {
                        cube_inform.Text = "Darkfield";
                    }
                    break;
                case "1FPV":
                    if (Command_result == "ON")
                    {
                        gare_prevent_off.Enabled = true;
                        gare_prevent_on.Enabled = false;
                    }
                    if (Command_result == "OFF")
                    {
                        gare_prevent_off.Enabled = false;
                        gare_prevent_on.Enabled = true;
                    }
                    break;
                case "1UNIT":

                    unit_inform.Text = result[1]+ result[2];
                    break;
                case "LIGHT":
                    light_value.Text = result[1];
                    break;
                case "IDI":
                    switch (Command_result)
                    {
                        case "1":
                            if (result[2] == "1")
                            {
                                IDI1.Checked = true;
                            }
                            else
                            {
                                IDI1.Checked = false;
                            }
                            break;
                        case "2":
                            if (result[2] == "1")
                            {
                                IDI2.Checked = true;
                            }
                            else
                            {
                                IDI2.Checked = false;
                            }
                            break;
                        case "3":
                            if (result[2] == "1")
                            {
                                IDI3.Checked = true;
                            }
                            else
                            {
                                IDI3.Checked = false;
                            }
                            break;
                        case "4":
                            if (result[2] == "1")
                            {
                                IDI4.Checked = true;
                            }
                            else
                            {
                                IDI4.Checked = false;
                            }
                            break;
                        case "5":
                            if (result[2] == "1")
                            {
                                IDI5.Checked = true;
                            }
                            else
                            {
                                IDI5.Checked = false;
                            }
                            break;
                        case "6":
                            if (result[2] == "1")
                            {
                                IDI6.Checked = true;
                            }
                            else
                            {
                                IDI6.Checked = false;
                            }
                            break;
                        case "7":
                            if (result[2] == "1")
                            {
                                IDI7.Checked = true;
                            }
                            else
                            {
                                IDI7.Checked = false;
                            }
                            break;
                        case "8":
                            if (result[2] == "1")
                            {
                                IDI8.Checked = true;
                            }
                            else
                            {
                                IDI8.Checked = false;
                            }
                            break;
                    }
                    break;
            }
        }
        /// <summary>
        /// Send command "1LOG IN" to change Local to Remote mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remote_Click(object sender, EventArgs e)
        {
            
            WriteSerial(MX61_MX61L_Command.Login);
            Thread.Sleep(500);
            WriteSerial(MX61_MX61L_Command.LoginState);
            Thread.Sleep(500);
            WriteSerial(MX61_MX61L_Command.LoginState);
            Thread.Sleep(500);
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
            Thread.Sleep(500);
            WriteSerial(MX61_MX61L_Command.ObjectivePos);

        }
        /// <summary>
        /// Send command "1LOG OUT" to change Remote to Local mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Local_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Logout);
            Thread.Sleep(500);
            WriteSerial(MX61_MX61L_Command.LoginState);
            Thread.Sleep(500);
            WriteSerial(MX61_MX61L_Command.LoginState);

        }
        /// <summary>
        /// Write serial function
        /// </summary>
        /// <param name="CMD"></param>
        private void WriteSerial(string CMD)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    send_state.Checked = true;
                    sending_comand(CMD);
                    serialPort1.Write($"{CMD}\r\n");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "ComPort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void WriteSerial2(string CMD)
        {
            try
            {
                if (serialPort2.IsOpen)
                {
                    send_state.Checked = true;
                    sending_comand(CMD);
                    serialPort2.Write($"{CMD}\r\n");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "ComPort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Objective lens position 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pos1_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Objective(1));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective lens position 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pos2_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Objective(2));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective lens position 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pos3_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Objective(3));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective lens position 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pos4_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Objective(4));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective lens position 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pos5_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Objective(5));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective/AS lens position 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ob_as1_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Obj_AS(1));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective/AS lens position 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ob_as2_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Obj_AS(2));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective/AS lens position 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ob_as3_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Obj_AS(3));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective/AS lens position 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ob_as4_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Obj_AS(4));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Objective/AS lens position 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ob_as5_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Obj_AS(5));
            WriteSerial(MX61_MX61L_Command.ObjectivePos);
        }
        /// <summary>
        /// Cube state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cube_state_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Cube_Status);
        }
        /// <summary>
        /// Unit type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Unit_presence_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Unit_presence);
        }
        /// <summary>
        /// Gare prevention on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gare_prevent_on_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Gare_Prevent_on);
        }
        /// <summary>
        /// Gare prevention off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gare_prevent_off_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Gare_Prevent_off);
        }
        /// <summary>
        /// Gare prevention state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gare_state_Click(object sender, EventArgs e)
        {
            WriteSerial(MX61_MX61L_Command.Gare_Prevent_State);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comport_list.Items.Clear();
            getAvalablePorts();
        }

        private void clear_monotor_Click(object sender, EventArgs e)
        {
            richTextBox_recieve.Clear();
            
        }

        private void copy_to_Clipboard_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string line in richTextBox_recieve.Lines)
                sb.AppendLine(line);

            Clipboard.SetText(sb.ToString());
        }
      
        private void open_light_port_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort2.PortName = comport_light.Text;
                serialPort2.BaudRate = 115200;
                serialPort2.DataBits = 8;
                serialPort2.Parity = Parity.None;
                serialPort2.Open();
                
                if (serialPort2.IsOpen)
                {
                    open_light_port.Enabled = false;
                    trackBar1.Enabled = true;
                    close_light_port.Enabled = true;
                    ODI_1.Enabled = true;
                    ODI_2.Enabled = true;
                    ODI_3.Enabled = true;
                    ODI_4.Enabled = true;
                    timer1.Enabled = true;
                }
             }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ligthing Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void close_light_port_Click(object sender, EventArgs e)
        {
            WriteSerial2(Convert.ToString(0));
            light_value.Text = Convert.ToString(0);
            trackBar1.Value = 0;
            serialPort2.Close();
            close_light_port.Enabled = false;
            open_light_port.Enabled = true;
            trackBar1.Enabled = false;
            ODI_1.Enabled = false;
            ODI_2.Enabled = false;
            ODI_3.Enabled = false;
            ODI_4.Enabled = false;
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comport_light.Items.Clear();
            getAvalablePorts();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            WriteSerial2(HardwareInteface.Lighting(trackBar1.Value));
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                send_state.Checked = true;
                Handle_Serial_Rrturn(serialPort2.ReadLine());
                //richTextBox_recieve.Text = "Recieved: ";
                
            }
            catch (Exception EX)
            {
                //richTextBox_recieve.Text = "Timeout Exception";

            }
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial2(HardwareInteface.Lighting(trackBar1.Value));
        }

        private void ODI_1_CheckedChanged(object sender, EventArgs e)
        {
            if (ODI_1.Checked)
            {
                WriteSerial2(HardwareInteface.ODION(1));
            }
            else
            {
                WriteSerial2(HardwareInteface.ODIOFF(1));
            }
        }

        private void ODI_2_CheckedChanged(object sender, EventArgs e)
        {
            if (ODI_2.Checked)
            {
                WriteSerial2(HardwareInteface.ODION(2));
            }
            else
            {
                WriteSerial2(HardwareInteface.ODIOFF(2));
            }
        }

        private void ODI_3_CheckedChanged(object sender, EventArgs e)
        {
            if (ODI_3.Checked)
            {
                WriteSerial2(HardwareInteface.ODION(3));
            }
            else
            {
                WriteSerial2(HardwareInteface.ODIOFF(3));
            }
        }

        private void ODI_4_CheckedChanged(object sender, EventArgs e)
        {
            if (ODI_4.Checked)
            {
                WriteSerial2(HardwareInteface.ODION(4));
            }
            else
            {
                WriteSerial2(HardwareInteface.ODIOFF(4));
            }
        }

       
    }
}
