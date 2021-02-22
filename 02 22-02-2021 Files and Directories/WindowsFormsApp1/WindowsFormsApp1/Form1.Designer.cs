namespace WindowsFormsApp1
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRAllF = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnRLines = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGetStudents = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(111, 69);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(119, 34);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write 2 File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRAllF
            // 
            this.btnRAllF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAllF.Location = new System.Drawing.Point(111, 139);
            this.btnRAllF.Name = "btnRAllF";
            this.btnRAllF.Size = new System.Drawing.Size(119, 34);
            this.btnRAllF.TabIndex = 1;
            this.btnRAllF.Text = "Read All From File";
            this.btnRAllF.UseVisualStyleBackColor = true;
            this.btnRAllF.Click += new System.EventHandler(this.btnRAllF_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(108, 263);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 20);
            this.lblRes.TabIndex = 2;
            // 
            // btnRLines
            // 
            this.btnRLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRLines.Location = new System.Drawing.Point(111, 197);
            this.btnRLines.Name = "btnRLines";
            this.btnRLines.Size = new System.Drawing.Size(119, 34);
            this.btnRLines.TabIndex = 3;
            this.btnRLines.Text = "Read Lines From File";
            this.btnRLines.UseVisualStyleBackColor = true;
            this.btnRLines.Click += new System.EventHandler(this.btnRLines_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(517, 69);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(119, 34);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(397, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 5;
            // 
            // btnGetStudents
            // 
            this.btnGetStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStudents.Location = new System.Drawing.Point(517, 126);
            this.btnGetStudents.Name = "btnGetStudents";
            this.btnGetStudents.Size = new System.Drawing.Size(119, 34);
            this.btnGetStudents.TabIndex = 6;
            this.btnGetStudents.Text = "Get Students";
            this.btnGetStudents.UseVisualStyleBackColor = true;
            this.btnGetStudents.Click += new System.EventHandler(this.btnGetStudents_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(513, 251);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(0, 20);
            this.lblStudent.TabIndex = 7;
            // 
            // btnAvg
            // 
            this.btnAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvg.Location = new System.Drawing.Point(517, 186);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(119, 34);
            this.btnAvg.TabIndex = 8;
            this.btnAvg.Text = "Get Avg";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnGetStudents);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRLines);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnRAllF);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRAllF;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnRLines;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGetStudents;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnAvg;
    }
}

