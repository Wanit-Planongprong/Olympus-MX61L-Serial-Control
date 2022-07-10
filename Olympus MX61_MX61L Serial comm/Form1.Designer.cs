
namespace Olympus_MX61_MX61L_Serial_comm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_parity = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.comport_list = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Text_Command = new System.Windows.Forms.ComboBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.send_state = new System.Windows.Forms.RadioButton();
            this.copy_to_Clipboard = new System.Windows.Forms.Button();
            this.clear_monotor = new System.Windows.Forms.Button();
            this.richTextBox_recieve = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Remote = new System.Windows.Forms.Button();
            this.Local = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Obj = new System.Windows.Forms.TextBox();
            this.Pos5 = new System.Windows.Forms.Button();
            this.Pos4 = new System.Windows.Forms.Button();
            this.Pos3 = new System.Windows.Forms.Button();
            this.Pos2 = new System.Windows.Forms.Button();
            this.Pos1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ob_as5 = new System.Windows.Forms.Button();
            this.ob_as4 = new System.Windows.Forms.Button();
            this.ob_as3 = new System.Windows.Forms.Button();
            this.ob_as2 = new System.Windows.Forms.Button();
            this.ob_as1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cube_inform = new System.Windows.Forms.Label();
            this.cube_state = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.unit_inform = new System.Windows.Forms.Label();
            this.Unit_presence = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.gare_state = new System.Windows.Forms.Button();
            this.gare_prevent_off = new System.Windows.Forms.Button();
            this.gare_prevent_on = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.close_light_port = new System.Windows.Forms.Button();
            this.light_value = new System.Windows.Forms.Label();
            this.open_light_port = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comport_light = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ODI_1 = new System.Windows.Forms.CheckBox();
            this.ODI_2 = new System.Windows.Forms.CheckBox();
            this.ODI_3 = new System.Windows.Forms.CheckBox();
            this.ODI_4 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IDI4 = new System.Windows.Forms.CheckBox();
            this.IDI3 = new System.Windows.Forms.CheckBox();
            this.IDI2 = new System.Windows.Forms.CheckBox();
            this.IDI1 = new System.Windows.Forms.CheckBox();
            this.IDI8 = new System.Windows.Forms.CheckBox();
            this.IDI7 = new System.Windows.Forms.CheckBox();
            this.IDI6 = new System.Windows.Forms.CheckBox();
            this.IDI5 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.combo_parity);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.comport_list);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Parity";
            // 
            // combo_parity
            // 
            this.combo_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_parity.FormattingEnabled = true;
            this.combo_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.combo_parity.Location = new System.Drawing.Point(329, 35);
            this.combo_parity.Name = "combo_parity";
            this.combo_parity.Size = new System.Drawing.Size(48, 21);
            this.combo_parity.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(266, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Com Port";
            // 
            // close_btn
            // 
            this.close_btn.Enabled = false;
            this.close_btn.Location = new System.Drawing.Point(475, 29);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(84, 31);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close Port";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(383, 29);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(86, 31);
            this.open_btn.TabIndex = 2;
            this.open_btn.Text = "Open Port";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // comport_list
            // 
            this.comport_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comport_list.FormattingEnabled = true;
            this.comport_list.Location = new System.Drawing.Point(74, 35);
            this.comport_list.Name = "comport_list";
            this.comport_list.Size = new System.Drawing.Size(192, 21);
            this.comport_list.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 442);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(805, 10);
            this.progressBar1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Text_Command);
            this.groupBox2.Controls.Add(this.send_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command Line";
            // 
            // Text_Command
            // 
            this.Text_Command.Enabled = false;
            this.Text_Command.FormattingEnabled = true;
            this.Text_Command.Items.AddRange(new object[] {
            "1LOG IN",
            "1LOG OUT",
            "1LOG?",
            "1OB 1",
            "1OB 2",
            "1OB 3",
            "1OB 4",
            "1OB 5",
            "1OB?",
            "1OBA 1",
            "1OBA 2",
            "1OBA 3",
            "1OBA 4",
            "1OBA 5",
            "1OBA?",
            "1CUBE?",
            "1UNIT?",
            "1FPV ON",
            "1FPV OFF",
            "1FPV?"});
            this.Text_Command.Location = new System.Drawing.Point(18, 22);
            this.Text_Command.Name = "Text_Command";
            this.Text_Command.Size = new System.Drawing.Size(220, 21);
            this.Text_Command.TabIndex = 2;
            // 
            // send_btn
            // 
            this.send_btn.Enabled = false;
            this.send_btn.Location = new System.Drawing.Point(252, 20);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(79, 28);
            this.send_btn.TabIndex = 1;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.send_state);
            this.groupBox3.Controls.Add(this.copy_to_Clipboard);
            this.groupBox3.Controls.Add(this.clear_monotor);
            this.groupBox3.Controls.Add(this.richTextBox_recieve);
            this.groupBox3.Location = new System.Drawing.Point(570, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 221);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial Monitor";
            // 
            // send_state
            // 
            this.send_state.AutoSize = true;
            this.send_state.Enabled = false;
            this.send_state.ForeColor = System.Drawing.SystemColors.ControlText;
            this.send_state.Location = new System.Drawing.Point(8, 187);
            this.send_state.Name = "send_state";
            this.send_state.Size = new System.Drawing.Size(55, 17);
            this.send_state.TabIndex = 6;
            this.send_state.TabStop = true;
            this.send_state.Text = "Tx/Rx";
            this.send_state.UseVisualStyleBackColor = true;
            // 
            // copy_to_Clipboard
            // 
            this.copy_to_Clipboard.Location = new System.Drawing.Point(95, 180);
            this.copy_to_Clipboard.Name = "copy_to_Clipboard";
            this.copy_to_Clipboard.Size = new System.Drawing.Size(55, 30);
            this.copy_to_Clipboard.TabIndex = 5;
            this.copy_to_Clipboard.Text = "Copy";
            this.copy_to_Clipboard.UseVisualStyleBackColor = true;
            this.copy_to_Clipboard.Click += new System.EventHandler(this.copy_to_Clipboard_Click);
            // 
            // clear_monotor
            // 
            this.clear_monotor.Location = new System.Drawing.Point(156, 180);
            this.clear_monotor.Name = "clear_monotor";
            this.clear_monotor.Size = new System.Drawing.Size(55, 30);
            this.clear_monotor.TabIndex = 1;
            this.clear_monotor.Text = "Clear";
            this.clear_monotor.UseVisualStyleBackColor = true;
            this.clear_monotor.Click += new System.EventHandler(this.clear_monotor_Click);
            // 
            // richTextBox_recieve
            // 
            this.richTextBox_recieve.Location = new System.Drawing.Point(8, 27);
            this.richTextBox_recieve.Name = "richTextBox_recieve";
            this.richTextBox_recieve.ReadOnly = true;
            this.richTextBox_recieve.Size = new System.Drawing.Size(203, 143);
            this.richTextBox_recieve.TabIndex = 0;
            this.richTextBox_recieve.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Remote
            // 
            this.Remote.Enabled = false;
            this.Remote.Location = new System.Drawing.Point(377, 125);
            this.Remote.Name = "Remote";
            this.Remote.Size = new System.Drawing.Size(79, 30);
            this.Remote.TabIndex = 4;
            this.Remote.Text = "Remote";
            this.Remote.UseVisualStyleBackColor = true;
            this.Remote.Click += new System.EventHandler(this.Remote_Click);
            // 
            // Local
            // 
            this.Local.Enabled = false;
            this.Local.Location = new System.Drawing.Point(462, 125);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(78, 30);
            this.Local.TabIndex = 5;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            this.Local.Click += new System.EventHandler(this.Local_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_Obj);
            this.groupBox4.Controls.Add(this.Pos5);
            this.groupBox4.Controls.Add(this.Pos4);
            this.groupBox4.Controls.Add(this.Pos3);
            this.groupBox4.Controls.Add(this.Pos2);
            this.groupBox4.Controls.Add(this.Pos1);
            this.groupBox4.Location = new System.Drawing.Point(15, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 248);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Objective Lens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current";
            // 
            // textBox_Obj
            // 
            this.textBox_Obj.Enabled = false;
            this.textBox_Obj.Location = new System.Drawing.Point(56, 22);
            this.textBox_Obj.Name = "textBox_Obj";
            this.textBox_Obj.ReadOnly = true;
            this.textBox_Obj.Size = new System.Drawing.Size(28, 20);
            this.textBox_Obj.TabIndex = 5;
            // 
            // Pos5
            // 
            this.Pos5.Enabled = false;
            this.Pos5.Location = new System.Drawing.Point(17, 204);
            this.Pos5.Name = "Pos5";
            this.Pos5.Size = new System.Drawing.Size(67, 34);
            this.Pos5.TabIndex = 4;
            this.Pos5.Text = "100x";
            this.Pos5.UseVisualStyleBackColor = true;
            this.Pos5.Click += new System.EventHandler(this.Pos5_Click);
            // 
            // Pos4
            // 
            this.Pos4.Enabled = false;
            this.Pos4.Location = new System.Drawing.Point(17, 164);
            this.Pos4.Name = "Pos4";
            this.Pos4.Size = new System.Drawing.Size(67, 34);
            this.Pos4.TabIndex = 3;
            this.Pos4.Text = "50x";
            this.Pos4.UseVisualStyleBackColor = true;
            this.Pos4.Click += new System.EventHandler(this.Pos4_Click);
            // 
            // Pos3
            // 
            this.Pos3.Enabled = false;
            this.Pos3.Location = new System.Drawing.Point(17, 124);
            this.Pos3.Name = "Pos3";
            this.Pos3.Size = new System.Drawing.Size(67, 34);
            this.Pos3.TabIndex = 2;
            this.Pos3.Text = "20x";
            this.Pos3.UseVisualStyleBackColor = true;
            this.Pos3.Click += new System.EventHandler(this.Pos3_Click);
            // 
            // Pos2
            // 
            this.Pos2.Enabled = false;
            this.Pos2.Location = new System.Drawing.Point(17, 84);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(67, 34);
            this.Pos2.TabIndex = 1;
            this.Pos2.Text = "10x";
            this.Pos2.UseVisualStyleBackColor = true;
            this.Pos2.Click += new System.EventHandler(this.Pos2_Click);
            // 
            // Pos1
            // 
            this.Pos1.Enabled = false;
            this.Pos1.Location = new System.Drawing.Point(17, 44);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(67, 34);
            this.Pos1.TabIndex = 0;
            this.Pos1.Text = "5x";
            this.Pos1.UseVisualStyleBackColor = true;
            this.Pos1.Click += new System.EventHandler(this.Pos1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.ob_as5);
            this.groupBox5.Controls.Add(this.ob_as4);
            this.groupBox5.Controls.Add(this.ob_as3);
            this.groupBox5.Controls.Add(this.ob_as2);
            this.groupBox5.Controls.Add(this.ob_as1);
            this.groupBox5.Location = new System.Drawing.Point(160, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(131, 248);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Objective/Aperture Iris";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(136, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(160, 70);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Unit Presence";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(48, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current";
            // 
            // ob_as5
            // 
            this.ob_as5.Enabled = false;
            this.ob_as5.Location = new System.Drawing.Point(11, 204);
            this.ob_as5.Name = "ob_as5";
            this.ob_as5.Size = new System.Drawing.Size(67, 34);
            this.ob_as5.TabIndex = 4;
            this.ob_as5.Text = "OB/AS5";
            this.ob_as5.UseVisualStyleBackColor = true;
            this.ob_as5.Click += new System.EventHandler(this.ob_as5_Click);
            // 
            // ob_as4
            // 
            this.ob_as4.Enabled = false;
            this.ob_as4.Location = new System.Drawing.Point(11, 164);
            this.ob_as4.Name = "ob_as4";
            this.ob_as4.Size = new System.Drawing.Size(67, 34);
            this.ob_as4.TabIndex = 3;
            this.ob_as4.Text = "OB/AS4";
            this.ob_as4.UseVisualStyleBackColor = true;
            this.ob_as4.Click += new System.EventHandler(this.ob_as4_Click);
            // 
            // ob_as3
            // 
            this.ob_as3.Enabled = false;
            this.ob_as3.Location = new System.Drawing.Point(11, 124);
            this.ob_as3.Name = "ob_as3";
            this.ob_as3.Size = new System.Drawing.Size(67, 34);
            this.ob_as3.TabIndex = 2;
            this.ob_as3.Text = "OB/AS3";
            this.ob_as3.UseVisualStyleBackColor = true;
            this.ob_as3.Click += new System.EventHandler(this.ob_as3_Click);
            // 
            // ob_as2
            // 
            this.ob_as2.Enabled = false;
            this.ob_as2.Location = new System.Drawing.Point(11, 84);
            this.ob_as2.Name = "ob_as2";
            this.ob_as2.Size = new System.Drawing.Size(67, 34);
            this.ob_as2.TabIndex = 1;
            this.ob_as2.Text = "OB/AS2";
            this.ob_as2.UseVisualStyleBackColor = true;
            this.ob_as2.Click += new System.EventHandler(this.ob_as2_Click);
            // 
            // ob_as1
            // 
            this.ob_as1.Enabled = false;
            this.ob_as1.Location = new System.Drawing.Point(11, 44);
            this.ob_as1.Name = "ob_as1";
            this.ob_as1.Size = new System.Drawing.Size(67, 34);
            this.ob_as1.TabIndex = 0;
            this.ob_as1.Text = "OB/AS1";
            this.ob_as1.UseVisualStyleBackColor = true;
            this.ob_as1.Click += new System.EventHandler(this.ob_as1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cube_inform);
            this.groupBox6.Controls.Add(this.cube_state);
            this.groupBox6.Location = new System.Drawing.Point(297, 178);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 70);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cube Status Check";
            // 
            // cube_inform
            // 
            this.cube_inform.AutoSize = true;
            this.cube_inform.Location = new System.Drawing.Point(9, 53);
            this.cube_inform.Name = "cube_inform";
            this.cube_inform.Size = new System.Drawing.Size(0, 13);
            this.cube_inform.TabIndex = 11;
            // 
            // cube_state
            // 
            this.cube_state.Enabled = false;
            this.cube_state.Location = new System.Drawing.Point(9, 16);
            this.cube_state.Name = "cube_state";
            this.cube_state.Size = new System.Drawing.Size(67, 34);
            this.cube_state.TabIndex = 10;
            this.cube_state.Text = "Cube?";
            this.cube_state.UseVisualStyleBackColor = true;
            this.cube_state.Click += new System.EventHandler(this.cube_state_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.unit_inform);
            this.groupBox7.Controls.Add(this.Unit_presence);
            this.groupBox7.Location = new System.Drawing.Point(297, 256);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 70);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unit Presence";
            // 
            // unit_inform
            // 
            this.unit_inform.AutoSize = true;
            this.unit_inform.Location = new System.Drawing.Point(6, 54);
            this.unit_inform.Name = "unit_inform";
            this.unit_inform.Size = new System.Drawing.Size(0, 13);
            this.unit_inform.TabIndex = 12;
            // 
            // Unit_presence
            // 
            this.Unit_presence.Enabled = false;
            this.Unit_presence.Location = new System.Drawing.Point(6, 18);
            this.Unit_presence.Name = "Unit_presence";
            this.Unit_presence.Size = new System.Drawing.Size(67, 34);
            this.Unit_presence.TabIndex = 11;
            this.Unit_presence.Text = "Unit?";
            this.Unit_presence.UseVisualStyleBackColor = true;
            this.Unit_presence.Click += new System.EventHandler(this.Unit_presence_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.gare_state);
            this.groupBox9.Controls.Add(this.gare_prevent_off);
            this.groupBox9.Controls.Add(this.gare_prevent_on);
            this.groupBox9.Location = new System.Drawing.Point(416, 177);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(147, 149);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Glare Prevention Setting";
            // 
            // gare_state
            // 
            this.gare_state.Enabled = false;
            this.gare_state.Location = new System.Drawing.Point(8, 104);
            this.gare_state.Name = "gare_state";
            this.gare_state.Size = new System.Drawing.Size(67, 34);
            this.gare_state.TabIndex = 13;
            this.gare_state.Text = "Gare State";
            this.gare_state.UseVisualStyleBackColor = true;
            this.gare_state.Click += new System.EventHandler(this.gare_state_Click);
            // 
            // gare_prevent_off
            // 
            this.gare_prevent_off.Enabled = false;
            this.gare_prevent_off.Location = new System.Drawing.Point(8, 64);
            this.gare_prevent_off.Name = "gare_prevent_off";
            this.gare_prevent_off.Size = new System.Drawing.Size(67, 34);
            this.gare_prevent_off.TabIndex = 12;
            this.gare_prevent_off.Text = "Gare Off";
            this.gare_prevent_off.UseVisualStyleBackColor = true;
            this.gare_prevent_off.Click += new System.EventHandler(this.gare_prevent_off_Click);
            // 
            // gare_prevent_on
            // 
            this.gare_prevent_on.Enabled = false;
            this.gare_prevent_on.Location = new System.Drawing.Point(8, 24);
            this.gare_prevent_on.Name = "gare_prevent_on";
            this.gare_prevent_on.Size = new System.Drawing.Size(67, 34);
            this.gare_prevent_on.TabIndex = 11;
            this.gare_prevent_on.Text = "Gare ON";
            this.gare_prevent_on.UseVisualStyleBackColor = true;
            this.gare_prevent_on.Click += new System.EventHandler(this.gare_prevent_on_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "UTAC Thai Automation © 2022";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.IDI8);
            this.groupBox10.Controls.Add(this.IDI7);
            this.groupBox10.Controls.Add(this.IDI6);
            this.groupBox10.Controls.Add(this.IDI5);
            this.groupBox10.Controls.Add(this.IDI4);
            this.groupBox10.Controls.Add(this.IDI3);
            this.groupBox10.Controls.Add(this.IDI2);
            this.groupBox10.Controls.Add(this.IDI1);
            this.groupBox10.Controls.Add(this.ODI_4);
            this.groupBox10.Controls.Add(this.ODI_3);
            this.groupBox10.Controls.Add(this.ODI_2);
            this.groupBox10.Controls.Add(this.ODI_1);
            this.groupBox10.Controls.Add(this.close_light_port);
            this.groupBox10.Controls.Add(this.light_value);
            this.groupBox10.Controls.Add(this.open_light_port);
            this.groupBox10.Controls.Add(this.button2);
            this.groupBox10.Controls.Add(this.comport_light);
            this.groupBox10.Controls.Add(this.trackBar1);
            this.groupBox10.Location = new System.Drawing.Point(296, 332);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(492, 96);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Lighting Control";
            // 
            // close_light_port
            // 
            this.close_light_port.Enabled = false;
            this.close_light_port.Location = new System.Drawing.Point(191, 21);
            this.close_light_port.Name = "close_light_port";
            this.close_light_port.Size = new System.Drawing.Size(57, 25);
            this.close_light_port.TabIndex = 5;
            this.close_light_port.Text = "Close";
            this.close_light_port.UseVisualStyleBackColor = true;
            this.close_light_port.Click += new System.EventHandler(this.close_light_port_Click);
            // 
            // light_value
            // 
            this.light_value.AutoSize = true;
            this.light_value.Location = new System.Drawing.Point(201, 62);
            this.light_value.Name = "light_value";
            this.light_value.Size = new System.Drawing.Size(26, 13);
            this.light_value.TabIndex = 4;
            this.light_value.Text = "light";
            // 
            // open_light_port
            // 
            this.open_light_port.Location = new System.Drawing.Point(128, 21);
            this.open_light_port.Name = "open_light_port";
            this.open_light_port.Size = new System.Drawing.Size(57, 25);
            this.open_light_port.TabIndex = 3;
            this.open_light_port.Text = "Open";
            this.open_light_port.UseVisualStyleBackColor = true;
            this.open_light_port.Click += new System.EventHandler(this.open_light_port_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Olympus_MX61_MX61L_Serial_comm.Properties.Resources.kisspng_computer_icons_desktop_wallpaper_5ae3c4d52729f0_4389372115248765011604;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(99, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comport_light
            // 
            this.comport_light.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comport_light.FormattingEnabled = true;
            this.comport_light.Location = new System.Drawing.Point(10, 22);
            this.comport_light.Name = "comport_light";
            this.comport_light.Size = new System.Drawing.Size(83, 21);
            this.comport_light.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(1, 49);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Olympus_MX61_MX61L_Serial_comm.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(646, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 36);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ODI_1
            // 
            this.ODI_1.AutoSize = true;
            this.ODI_1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ODI_1.Enabled = false;
            this.ODI_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ODI_1.Location = new System.Drawing.Point(254, 59);
            this.ODI_1.Name = "ODI_1";
            this.ODI_1.Size = new System.Drawing.Size(31, 30);
            this.ODI_1.TabIndex = 7;
            this.ODI_1.Text = "ODI1";
            this.ODI_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ODI_1.UseVisualStyleBackColor = true;
            this.ODI_1.CheckedChanged += new System.EventHandler(this.ODI_1_CheckedChanged);
            // 
            // ODI_2
            // 
            this.ODI_2.AutoSize = true;
            this.ODI_2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ODI_2.Enabled = false;
            this.ODI_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ODI_2.Location = new System.Drawing.Point(280, 59);
            this.ODI_2.Name = "ODI_2";
            this.ODI_2.Size = new System.Drawing.Size(31, 30);
            this.ODI_2.TabIndex = 7;
            this.ODI_2.Text = "ODI2";
            this.ODI_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ODI_2.UseVisualStyleBackColor = true;
            this.ODI_2.CheckedChanged += new System.EventHandler(this.ODI_2_CheckedChanged);
            // 
            // ODI_3
            // 
            this.ODI_3.AutoSize = true;
            this.ODI_3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ODI_3.Enabled = false;
            this.ODI_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ODI_3.Location = new System.Drawing.Point(310, 59);
            this.ODI_3.Name = "ODI_3";
            this.ODI_3.Size = new System.Drawing.Size(31, 30);
            this.ODI_3.TabIndex = 7;
            this.ODI_3.Text = "ODI3";
            this.ODI_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ODI_3.UseVisualStyleBackColor = true;
            this.ODI_3.CheckedChanged += new System.EventHandler(this.ODI_3_CheckedChanged);
            // 
            // ODI_4
            // 
            this.ODI_4.AutoSize = true;
            this.ODI_4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ODI_4.Enabled = false;
            this.ODI_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ODI_4.Location = new System.Drawing.Point(340, 59);
            this.ODI_4.Name = "ODI_4";
            this.ODI_4.Size = new System.Drawing.Size(31, 30);
            this.ODI_4.TabIndex = 7;
            this.ODI_4.Text = "ODI4";
            this.ODI_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ODI_4.UseVisualStyleBackColor = true;
            this.ODI_4.CheckedChanged += new System.EventHandler(this.ODI_4_CheckedChanged);
            // 
            // IDI4
            // 
            this.IDI4.AutoSize = true;
            this.IDI4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI4.Enabled = false;
            this.IDI4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI4.Location = new System.Drawing.Point(343, 18);
            this.IDI4.Name = "IDI4";
            this.IDI4.Size = new System.Drawing.Size(27, 30);
            this.IDI4.TabIndex = 8;
            this.IDI4.Text = "IDI4";
            this.IDI4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI4.UseVisualStyleBackColor = true;
            // 
            // IDI3
            // 
            this.IDI3.AutoSize = true;
            this.IDI3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI3.Enabled = false;
            this.IDI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI3.Location = new System.Drawing.Point(313, 18);
            this.IDI3.Name = "IDI3";
            this.IDI3.Size = new System.Drawing.Size(27, 30);
            this.IDI3.TabIndex = 9;
            this.IDI3.Text = "IDI3";
            this.IDI3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI3.UseVisualStyleBackColor = true;
            // 
            // IDI2
            // 
            this.IDI2.AutoSize = true;
            this.IDI2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI2.Enabled = false;
            this.IDI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI2.Location = new System.Drawing.Point(283, 18);
            this.IDI2.Name = "IDI2";
            this.IDI2.Size = new System.Drawing.Size(27, 30);
            this.IDI2.TabIndex = 10;
            this.IDI2.Text = "IDI2";
            this.IDI2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI2.UseVisualStyleBackColor = true;
            // 
            // IDI1
            // 
            this.IDI1.AutoSize = true;
            this.IDI1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI1.Enabled = false;
            this.IDI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI1.Location = new System.Drawing.Point(257, 18);
            this.IDI1.Name = "IDI1";
            this.IDI1.Size = new System.Drawing.Size(27, 30);
            this.IDI1.TabIndex = 11;
            this.IDI1.Text = "IDI1";
            this.IDI1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI1.UseVisualStyleBackColor = true;
            // 
            // IDI8
            // 
            this.IDI8.AutoSize = true;
            this.IDI8.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI8.Enabled = false;
            this.IDI8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI8.Location = new System.Drawing.Point(462, 18);
            this.IDI8.Name = "IDI8";
            this.IDI8.Size = new System.Drawing.Size(27, 30);
            this.IDI8.TabIndex = 12;
            this.IDI8.Text = "IDI8";
            this.IDI8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI8.UseVisualStyleBackColor = true;
            // 
            // IDI7
            // 
            this.IDI7.AutoSize = true;
            this.IDI7.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI7.Enabled = false;
            this.IDI7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI7.Location = new System.Drawing.Point(432, 18);
            this.IDI7.Name = "IDI7";
            this.IDI7.Size = new System.Drawing.Size(27, 30);
            this.IDI7.TabIndex = 13;
            this.IDI7.Text = "IDI7";
            this.IDI7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI7.UseVisualStyleBackColor = true;
            // 
            // IDI6
            // 
            this.IDI6.AutoSize = true;
            this.IDI6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI6.Enabled = false;
            this.IDI6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI6.Location = new System.Drawing.Point(402, 18);
            this.IDI6.Name = "IDI6";
            this.IDI6.Size = new System.Drawing.Size(27, 30);
            this.IDI6.TabIndex = 14;
            this.IDI6.Text = "IDI6";
            this.IDI6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI6.UseVisualStyleBackColor = true;
            // 
            // IDI5
            // 
            this.IDI5.AutoSize = true;
            this.IDI5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDI5.Enabled = false;
            this.IDI5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IDI5.Location = new System.Drawing.Point(372, 18);
            this.IDI5.Name = "IDI5";
            this.IDI5.Size = new System.Drawing.Size(27, 30);
            this.IDI5.TabIndex = 15;
            this.IDI5.Text = "IDI5";
            this.IDI5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDI5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.Remote);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Olympus MX61/MX61L Serial control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox comport_list;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_recieve;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Remote;
        private System.Windows.Forms.Button Local;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Obj;
        private System.Windows.Forms.Button Pos5;
        private System.Windows.Forms.Button Pos4;
        private System.Windows.Forms.Button Pos3;
        private System.Windows.Forms.Button Pos2;
        private System.Windows.Forms.Button Pos1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ob_as5;
        private System.Windows.Forms.Button ob_as4;
        private System.Windows.Forms.Button ob_as3;
        private System.Windows.Forms.Button ob_as2;
        private System.Windows.Forms.Button ob_as1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button cube_state;
        private System.Windows.Forms.Button Unit_presence;
        private System.Windows.Forms.Button gare_state;
        private System.Windows.Forms.Button gare_prevent_off;
        private System.Windows.Forms.Button gare_prevent_on;
        private System.Windows.Forms.ComboBox Text_Command;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button clear_monotor;
        private System.Windows.Forms.Label cube_inform;
        private System.Windows.Forms.Label unit_inform;
        private System.Windows.Forms.Button copy_to_Clipboard;
        private System.Windows.Forms.ComboBox combo_parity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comport_light;
        private System.Windows.Forms.Button open_light_port;
        private System.Windows.Forms.Button close_light_port;
        private System.Windows.Forms.Label light_value;
        private System.Windows.Forms.RadioButton send_state;
        private System.Windows.Forms.CheckBox ODI_1;
        private System.Windows.Forms.CheckBox ODI_4;
        private System.Windows.Forms.CheckBox ODI_3;
        private System.Windows.Forms.CheckBox ODI_2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox IDI8;
        private System.Windows.Forms.CheckBox IDI7;
        private System.Windows.Forms.CheckBox IDI6;
        private System.Windows.Forms.CheckBox IDI5;
        private System.Windows.Forms.CheckBox IDI4;
        private System.Windows.Forms.CheckBox IDI3;
        private System.Windows.Forms.CheckBox IDI2;
        private System.Windows.Forms.CheckBox IDI1;
    }
}

