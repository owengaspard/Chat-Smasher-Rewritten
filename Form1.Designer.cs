namespace Chat_Smasher_Rewritten
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
            this.charCount = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusIdle = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.dateUpdate = new System.Windows.Forms.Timer(this.components);
            this.appInitialize = new System.Windows.Forms.Timer(this.components);
            this.actCheck = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneVTrackBar1 = new Siticone.UI.WinForms.SiticoneVTrackBar();
            this.timerValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.onTopCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.formDrag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.formElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.ForeColor = System.Drawing.Color.White;
            this.charCount.Location = new System.Drawing.Point(164, 43);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(19, 13);
            this.charCount.TabIndex = 63;
            this.charCount.Text = "40";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 59);
            this.textBox2.MaxLength = 2000;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(466, 407);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = "Type Your Text In Here Then Press Send\r\n\r\n\r\n\r\n\r\n\r\n";
            this.textBox2.TextChanged += new System.EventHandler(this.spamBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 33);
            this.label5.TabIndex = 65;
            this.label5.Text = "Chat Smasher Rewritten";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Text Count:";
            // 
            // statusIdle
            // 
            this.statusIdle.AutoSize = true;
            this.statusIdle.ForeColor = System.Drawing.Color.Yellow;
            this.statusIdle.Location = new System.Drawing.Point(52, 43);
            this.statusIdle.Name = "statusIdle";
            this.statusIdle.Size = new System.Drawing.Size(24, 13);
            this.statusIdle.TabIndex = 67;
            this.statusIdle.Text = "Idle";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Location = new System.Drawing.Point(15, 43);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(40, 13);
            this.statusText.TabIndex = 66;
            this.statusText.Text = "Status:";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = null;
            // 
            // dateUpdate
            // 
            this.dateUpdate.Enabled = true;
            this.dateUpdate.Interval = 1000;
            // 
            // appInitialize
            // 
            this.appInitialize.Tick += new System.EventHandler(this.appInitialize_Tick);
            // 
            // actCheck
            // 
            this.actCheck.Interval = 150;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.siticoneRoundedButton3.BorderThickness = 1;
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(484, 59);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(87, 41);
            this.siticoneRoundedButton3.TabIndex = 75;
            this.siticoneRoundedButton3.Text = "Start";
            this.siticoneRoundedButton3.Click += new System.EventHandler(this.siticoneRoundedButton3_Click);
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(484, 106);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(87, 41);
            this.siticoneRoundedButton2.TabIndex = 74;
            this.siticoneRoundedButton2.Text = "Stop";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(476, 9);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 73;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(527, 9);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 72;
            // 
            // siticoneVTrackBar1
            // 
            this.siticoneVTrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.siticoneVTrackBar1.HoveredState.Parent = this.siticoneVTrackBar1;
            this.siticoneVTrackBar1.Location = new System.Drawing.Point(484, 191);
            this.siticoneVTrackBar1.Maximum = 2000;
            this.siticoneVTrackBar1.Minimum = 200;
            this.siticoneVTrackBar1.Name = "siticoneVTrackBar1";
            this.siticoneVTrackBar1.Size = new System.Drawing.Size(23, 275);
            this.siticoneVTrackBar1.TabIndex = 76;
            this.siticoneVTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.siticoneVTrackBar1.Value = 1100;
            this.siticoneVTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneVTrackBar1_Scroll);
            // 
            // timerValue
            // 
            this.timerValue.AutoSize = true;
            this.timerValue.ForeColor = System.Drawing.Color.White;
            this.timerValue.Location = new System.Drawing.Point(521, 321);
            this.timerValue.Name = "timerValue";
            this.timerValue.Size = new System.Drawing.Size(44, 13);
            this.timerValue.TabIndex = 82;
            this.timerValue.Text = "1100ms";
            this.timerValue.Click += new System.EventHandler(this.timerValue_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(521, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "200ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(524, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "2.0s";
            // 
            // onTopCheck
            // 
            this.onTopCheck.AutoSize = true;
            this.onTopCheck.Checked = true;
            this.onTopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onTopCheck.ForeColor = System.Drawing.Color.White;
            this.onTopCheck.Location = new System.Drawing.Point(323, 42);
            this.onTopCheck.Name = "onTopCheck";
            this.onTopCheck.Size = new System.Drawing.Size(92, 17);
            this.onTopCheck.TabIndex = 84;
            this.onTopCheck.Text = "Always on top";
            this.onTopCheck.UseVisualStyleBackColor = true;
            this.onTopCheck.CheckedChanged += new System.EventHandler(this.onTopCheck_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(202, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 83;
            this.checkBox1.Text = "Chill Zone Bypass";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // formDrag
            // 
            this.formDrag.TargetControl = this;
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "By using this software, you agree that you will not use it for any malicious inte" +
    "nt.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(583, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onTopCheck);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.timerValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.siticoneVTrackBar1);
            this.Controls.Add(this.siticoneRoundedButton3);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusIdle);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.charCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "CS Rewritten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label charCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statusIdle;
        private System.Windows.Forms.Label statusText;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Timer dateUpdate;
        private System.Windows.Forms.Timer appInitialize;
        private System.Windows.Forms.Timer actCheck;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneVTrackBar siticoneVTrackBar1;
        private System.Windows.Forms.Label timerValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox onTopCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private Siticone.UI.WinForms.SiticoneDragControl formDrag;
        private Siticone.UI.WinForms.SiticoneElipse formElipse;
        private System.Windows.Forms.Label label1;
    }
}

