namespace Employee
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
            this.EmployeeDetails = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.labelEmploymentStats = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.comboBoxstatus = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDetails
            // 
            this.EmployeeDetails.AutoSize = true;
            this.EmployeeDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeeDetails.Location = new System.Drawing.Point(152, 9);
            this.EmployeeDetails.Name = "EmployeeDetails";
            this.EmployeeDetails.Size = new System.Drawing.Size(279, 37);
            this.EmployeeDetails.TabIndex = 0;
            this.EmployeeDetails.Text = "Employee Details";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(23, 88);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(67, 13);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "First Name";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursWorked.Location = new System.Drawing.Point(264, 115);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(88, 13);
            this.labelHoursWorked.TabIndex = 2;
            this.labelHoursWorked.Text = "Hours Worked";
            // 
            // labelEmploymentStats
            // 
            this.labelEmploymentStats.AutoSize = true;
            this.labelEmploymentStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmploymentStats.Location = new System.Drawing.Point(263, 88);
            this.labelEmploymentStats.Name = "labelEmploymentStats";
            this.labelEmploymentStats.Size = new System.Drawing.Size(114, 13);
            this.labelEmploymentStats.TabIndex = 3;
            this.labelEmploymentStats.Text = "Employment Status";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(24, 159);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 13);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(23, 115);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(67, 13);
            this.labelLname.TabIndex = 5;
            this.labelLname.Text = "Last Name";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.Location = new System.Drawing.Point(108, 84);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(116, 20);
            this.textBoxFname.TabIndex = 6;
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoursWorked.Location = new System.Drawing.Point(385, 108);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(116, 20);
            this.textBoxHoursWorked.TabIndex = 7;
            this.textBoxHoursWorked.Text = "0";
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLname.Location = new System.Drawing.Point(108, 108);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(116, 20);
            this.textBoxLname.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioMale);
            this.panel1.Controls.Add(this.radioFemale);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(108, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 32);
            this.panel1.TabIndex = 9;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioMale.Location = new System.Drawing.Point(100, 12);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(52, 17);
            this.radioMale.TabIndex = 1;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = false;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.BackColor = System.Drawing.SystemColors.HotTrack;
            this.radioFemale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radioFemale.Location = new System.Drawing.Point(3, 12);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(65, 17);
            this.radioFemale.TabIndex = 0;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = false;
            // 
            // comboBoxstatus
            // 
            this.comboBoxstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxstatus.FormattingEnabled = true;
            this.comboBoxstatus.Items.AddRange(new object[] {
            "Full time",
            "Part time"});
            this.comboBoxstatus.Location = new System.Drawing.Point(385, 83);
            this.comboBoxstatus.Name = "comboBoxstatus";
            this.comboBoxstatus.Size = new System.Drawing.Size(116, 21);
            this.comboBoxstatus.TabIndex = 10;
            this.comboBoxstatus.Text = "Full time";
            this.comboBoxstatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxstatus_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(337, 207);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(449, 207);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(60, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(393, 207);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(50, 23);
            this.Clear_button.TabIndex = 13;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 242);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxstatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxHoursWorked);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEmploymentStats);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.EmployeeDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeDetails;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Label labelEmploymentStats;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.ComboBox comboBoxstatus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button Clear_button;
    }
}

