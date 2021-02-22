namespace controls
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.MonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnTimer = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.picMypic = new System.Windows.Forms.PictureBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboPixis = new System.Windows.Forms.ComboBox();
            this.chkWhat = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblInFunction = new System.Windows.Forms.Label();
            this.chkDM = new System.Windows.Forms.CheckedListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtInFunction = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnB1 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMypic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(29, 88);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(14, 65);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(90, 17);
            this.RadioButton3.TabIndex = 15;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "RadioButton3";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(14, 42);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(90, 17);
            this.RadioButton2.TabIndex = 14;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "RadioButton2";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(14, 19);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(90, 17);
            this.RadioButton1.TabIndex = 13;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "RadioButton1";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(122, 532);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 36;
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(28, 532);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MonthCalendar1
            // 
            this.MonthCalendar1.Location = new System.Drawing.Point(339, 90);
            this.MonthCalendar1.Name = "MonthCalendar1";
            this.MonthCalendar1.TabIndex = 34;
            this.MonthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(28, 502);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 33;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCheck);
            this.GroupBox1.Controls.Add(this.RadioButton3);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(28, 363);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 119);
            this.GroupBox1.TabIndex = 32;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "GroupBox1";
            // 
            // picMypic
            // 
            this.picMypic.Image = ((System.Drawing.Image)(resources.GetObject("picMypic.Image")));
            this.picMypic.Location = new System.Drawing.Point(308, 309);
            this.picMypic.Name = "picMypic";
            this.picMypic.Size = new System.Drawing.Size(101, 101);
            this.picMypic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMypic.TabIndex = 31;
            this.picMypic.TabStop = false;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(25, 347);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(37, 13);
            this.LinkLabel1.TabIndex = 30;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Mylink";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(26, 309);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 29;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // cboPixis
            // 
            this.cboPixis.FormattingEnabled = true;
            this.cboPixis.Items.AddRange(new object[] {
            "been",
            "trying"});
            this.cboPixis.Location = new System.Drawing.Point(28, 264);
            this.cboPixis.Name = "cboPixis";
            this.cboPixis.Size = new System.Drawing.Size(121, 21);
            this.cboPixis.TabIndex = 28;
            this.cboPixis.SelectedIndexChanged += new System.EventHandler(this.cboPixis_SelectedIndexChanged);
            // 
            // chkWhat
            // 
            this.chkWhat.AutoSize = true;
            this.chkWhat.Location = new System.Drawing.Point(28, 228);
            this.chkWhat.Name = "chkWhat";
            this.chkWhat.Size = new System.Drawing.Size(61, 17);
            this.chkWhat.TabIndex = 27;
            this.chkWhat.Text = "What?!";
            this.chkWhat.UseVisualStyleBackColor = true;
            this.chkWhat.CheckedChanged += new System.EventHandler(this.chkWhat_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(17, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(559, 13);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "the Sender";
            // 
            // lblInFunction
            // 
            this.lblInFunction.AutoSize = true;
            this.lblInFunction.Location = new System.Drawing.Point(87, 14);
            this.lblInFunction.Name = "lblInFunction";
            this.lblInFunction.Size = new System.Drawing.Size(0, 13);
            this.lblInFunction.TabIndex = 24;
            // 
            // chkDM
            // 
            this.chkDM.FormattingEnabled = true;
            this.chkDM.Items.AddRange(new object[] {
            "words",
            "are ",
            "very",
            "unnessasary"});
            this.chkDM.Location = new System.Drawing.Point(26, 153);
            this.chkDM.Name = "chkDM";
            this.chkDM.Size = new System.Drawing.Size(92, 64);
            this.chkDM.TabIndex = 23;
            this.chkDM.SelectedIndexChanged += new System.EventHandler(this.chkDM_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "in Function";
            // 
            // txtInFunction
            // 
            this.txtInFunction.Location = new System.Drawing.Point(81, 39);
            this.txtInFunction.Name = "txtInFunction";
            this.txtInFunction.Size = new System.Drawing.Size(383, 20);
            this.txtInFunction.TabIndex = 21;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 118);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 13);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "myLabel";
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(81, 108);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(75, 23);
            this.btnB1.TabIndex = 19;
            this.btnB1.Text = "MyButton";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 581);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.MonthCalendar1);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.picMypic);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.cboPixis);
            this.Controls.Add(this.chkWhat);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblInFunction);
            this.Controls.Add(this.chkDM);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtInFunction);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMypic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCheck;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.MonthCalendar MonthCalendar1;
        internal System.Windows.Forms.Button btnTimer;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.PictureBox picMypic;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.ComboBox cboPixis;
        internal System.Windows.Forms.CheckBox chkWhat;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblInFunction;
        internal System.Windows.Forms.CheckedListBox chkDM;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtInFunction;
        internal System.Windows.Forms.Label lbl1;
        internal System.Windows.Forms.Button btnB1;

    }
}

