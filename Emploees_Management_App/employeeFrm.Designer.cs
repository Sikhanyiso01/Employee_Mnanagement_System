namespace Emploees_Management_App
{
    partial class employeeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emiIDT = new System.Windows.Forms.Label();
            this.empIdTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employees";
            // 
            // emiIDT
            // 
            this.emiIDT.AutoSize = true;
            this.emiIDT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emiIDT.ForeColor = System.Drawing.Color.White;
            this.emiIDT.Location = new System.Drawing.Point(65, 257);
            this.emiIDT.Name = "emiIDT";
            this.emiIDT.Size = new System.Drawing.Size(122, 22);
            this.emiIDT.TabIndex = 8;
            this.emiIDT.Text = "EmployeeID";
            // 
            // empIdTxt
            // 
            this.empIdTxt.Location = new System.Drawing.Point(68, 287);
            this.empIdTxt.Name = "empIdTxt";
            this.empIdTxt.Size = new System.Drawing.Size(165, 22);
            this.empIdTxt.TabIndex = 9;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(68, 374);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(165, 22);
            this.nameTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gender";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Fenale",
            "Prefer Not To Say"});
            this.gender.Location = new System.Drawing.Point(70, 475);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(164, 24);
            this.gender.TabIndex = 13;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(307, 108);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(165, 22);
            this.addressTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(304, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Position";
            // 
            // pos
            // 
            this.pos.FormattingEnabled = true;
            this.pos.Items.AddRange(new object[] {
            "Software Developer",
            "",
            "Project Manager",
            "",
            "Human Resources Manager",
            "",
            "Quality Assurance Analyst",
            "",
            "IT Support Specialist"});
            this.pos.Location = new System.Drawing.Point(308, 196);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(164, 24);
            this.pos.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(303, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date Of Birth";
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(302, 287);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(170, 26);
            this.dob.TabIndex = 19;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(301, 374);
            this.phonetxt.Multiline = true;
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(165, 22);
            this.phonetxt.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(298, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phone";
            // 
            // edu
            // 
            this.edu.FormattingEnabled = true;
            this.edu.Items.AddRange(new object[] {
            "High School Diploma",
            "Bachelors Degree",
            "Master\'s Degree",
            "Doctorate",
            "Diploma in a Specific Field"});
            this.edu.Location = new System.Drawing.Point(304, 475);
            this.edu.Name = "edu";
            this.edu.Size = new System.Drawing.Size(164, 24);
            this.edu.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(298, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Education";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1128, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 32);
            this.button3.TabIndex = 25;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(675, 101);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(401, 36);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(675, 196);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(401, 36);
            this.updateBtn.TabIndex = 27;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(675, 364);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(401, 32);
            this.homeBtn.TabIndex = 29;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // employeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1177, 606);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empIdTxt);
            this.Controls.Add(this.emiIDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emiIDT;
        private System.Windows.Forms.TextBox empIdTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox edu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homeBtn;
    }
}