namespace WindowsApplication
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelLname = new Label();
            labelFname = new Label();
            labelMname = new Label();
            labelGender = new Label();
            labelDoB = new Label();
            textBoxLname = new TextBox();
            textBoxFname = new TextBox();
            textBoxMname = new TextBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            comboBoxDay = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(262, 28);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLname.Location = new Point(19, 79);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(133, 28);
            labelLname.TabIndex = 1;
            labelLname.Text = "Last Name * ";
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFname.Location = new Point(19, 138);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(130, 28);
            labelFname.TabIndex = 2;
            labelFname.Text = "First Name *";
            // 
            // labelMname
            // 
            labelMname.AutoSize = true;
            labelMname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMname.Location = new Point(19, 198);
            labelMname.Name = "labelMname";
            labelMname.Size = new Size(155, 28);
            labelMname.TabIndex = 3;
            labelMname.Text = "Middle Name *";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.Location = new Point(19, 269);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(95, 28);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender *";
            // 
            // labelDoB
            // 
            labelDoB.AutoSize = true;
            labelDoB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDoB.Location = new Point(19, 318);
            labelDoB.Name = "labelDoB";
            labelDoB.Size = new Size(152, 28);
            labelDoB.TabIndex = 5;
            labelDoB.Text = "Date of Birth *";
            // 
            // textBoxLname
            // 
            textBoxLname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLname.Location = new Point(24, 107);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(365, 34);
            textBoxLname.TabIndex = 6;
            textBoxLname.TabStop = false;
            textBoxLname.TextChanged += textBoxLname_TextChanged;
            // 
            // textBoxFname
            // 
            textBoxFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFname.Location = new Point(24, 166);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(365, 34);
            textBoxFname.TabIndex = 7;
            textBoxFname.TabStop = false;
            textBoxFname.TextChanged += textBoxFname_TextChanged;
            // 
            // textBoxMname
            // 
            textBoxMname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMname.Location = new Point(24, 227);
            textBoxMname.Name = "textBoxMname";
            textBoxMname.Size = new Size(365, 34);
            textBoxMname.TabIndex = 8;
            textBoxMname.TabStop = false;
            textBoxMname.TextChanged += textBoxMname_TextChanged;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMale.Location = new Point(120, 269);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(76, 32);
            radioButtonMale.TabIndex = 9;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFemale.Location = new Point(202, 269);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(95, 32);
            radioButtonFemale.TabIndex = 10;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.CheckedChanged += radioButtonFemale_CheckedChanged;
            // 
            // comboBoxDay
            // 
            comboBoxDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Location = new Point(24, 349);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(90, 36);
            comboBoxDay.TabIndex = 11;
            comboBoxDay.TabStop = false;
            comboBoxDay.Text = "-Day-";
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(132, 349);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(106, 36);
            comboBoxMonth.TabIndex = 12;
            comboBoxMonth.TabStop = false;
            comboBoxMonth.Text = "-Month-";
            // 
            // comboBoxYear
            // 
            comboBoxYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(253, 349);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(106, 36);
            comboBoxYear.TabIndex = 13;
            comboBoxYear.TabStop = false;
            comboBoxYear.Text = "-Year-";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 394);
            button1.Name = "button1";
            button1.Size = new Size(182, 55);
            button1.TabIndex = 14;
            button1.Text = "Register Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 458);
            Controls.Add(button1);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxDay);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(textBoxMname);
            Controls.Add(textBoxFname);
            Controls.Add(textBoxLname);
            Controls.Add(labelDoB);
            Controls.Add(labelGender);
            Controls.Add(labelMname);
            Controls.Add(labelFname);
            Controls.Add(labelLname);
            Controls.Add(label1);
            Name = "frmStudentRegistration";
            Text = "Student Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelLname;
        private Label labelFname;
        private Label labelMname;
        private Label labelGender;
        private Label labelDoB;
        private TextBox textBoxLname;
        private TextBox textBoxFname;
        private TextBox textBoxMname;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private Button button1;
    }
}