namespace test
{
    partial class Assignment1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnHonors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProgrammerName = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(253, 112);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(497, 47);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "Jill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "GPA";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(253, 191);
            this.txtGPA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(495, 47);
            this.txtGPA.TabIndex = 3;
            this.txtGPA.Text = "3.01";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1025, 112);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(231, 41);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "August 25, 2022";
            // 
            // btnHonors
            // 
            this.btnHonors.Location = new System.Drawing.Point(90, 563);
            this.btnHonors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHonors.Name = "btnHonors";
            this.btnHonors.Size = new System.Drawing.Size(347, 87);
            this.btnHonors.TabIndex = 5;
            this.btnHonors.Text = "Honors Student?";
            this.btnHonors.UseVisualStyleBackColor = true;
            this.btnHonors.Click += new System.EventHandler(this.btnHonors_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(777, 563);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(342, 87);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblProgrammerName
            // 
            this.lblProgrammerName.AutoSize = true;
            this.lblProgrammerName.Location = new System.Drawing.Point(1044, 905);
            this.lblProgrammerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgrammerName.Name = "lblProgrammerName";
            this.lblProgrammerName.Size = new System.Drawing.Size(123, 41);
            this.lblProgrammerName.TabIndex = 7;
            this.lblProgrammerName.Text = "Yohhani";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(185, 383);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 41);
            this.lblMessage.TabIndex = 8;
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 845);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblProgrammerName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHonors);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Assignment1";
            this.Text = "Assignment1";
            this.Load += new System.EventHandler(this.Assignment1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private TextBox txtGPA;
        private Label lblDate;
        private Button btnHonors;
        private Button btnExit;
        private Label lblProgrammerName;
        private Label lblMessage;
    }
}