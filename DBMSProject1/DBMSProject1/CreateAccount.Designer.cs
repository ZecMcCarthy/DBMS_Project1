﻿namespace DBMSProject1
{
    partial class CreateAccount
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
            this.CreateNewUserAccount_label = new System.Windows.Forms.Label();
            this.CreateAccount_button1 = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_textbox1 = new System.Windows.Forms.TextBox();
            this.Username_textbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPassword_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailAddress_textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateNewUserAccount_label
            // 
            this.CreateNewUserAccount_label.AutoSize = true;
            this.CreateNewUserAccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewUserAccount_label.Location = new System.Drawing.Point(186, 33);
            this.CreateNewUserAccount_label.Name = "CreateNewUserAccount_label";
            this.CreateNewUserAccount_label.Size = new System.Drawing.Size(397, 38);
            this.CreateNewUserAccount_label.TabIndex = 0;
            this.CreateNewUserAccount_label.Text = "Create New User Account";
            // 
            // CreateAccount_button1
            // 
            this.CreateAccount_button1.Location = new System.Drawing.Point(339, 371);
            this.CreateAccount_button1.Name = "CreateAccount_button1";
            this.CreateAccount_button1.Size = new System.Drawing.Size(134, 37);
            this.CreateAccount_button1.TabIndex = 12;
            this.CreateAccount_button1.Text = "Create Account";
            this.CreateAccount_button1.UseVisualStyleBackColor = true;
            this.CreateAccount_button1.Click += new System.EventHandler(this.CreateAccount_button1_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(182, 151);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(100, 17);
            this.Password_label.TabIndex = 10;
            this.Password_label.Text = "New Password";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(178, 106);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(104, 17);
            this.Username_label.TabIndex = 9;
            this.Username_label.Text = "New Username";
            // 
            // Password_textbox1
            // 
            this.Password_textbox1.Location = new System.Drawing.Point(288, 148);
            this.Password_textbox1.Name = "Password_textbox1";
            this.Password_textbox1.PasswordChar = '*';
            this.Password_textbox1.Size = new System.Drawing.Size(250, 22);
            this.Password_textbox1.TabIndex = 8;
            this.Password_textbox1.TextChanged += new System.EventHandler(this.Password_textbox1_TextChanged);
            // 
            // Username_textbox1
            // 
            this.Username_textbox1.Location = new System.Drawing.Point(288, 106);
            this.Username_textbox1.Name = "Username_textbox1";
            this.Username_textbox1.Size = new System.Drawing.Size(250, 22);
            this.Username_textbox1.TabIndex = 7;
            this.Username_textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(209, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 13;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Confirm Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConfirmPassword_textBox1
            // 
            this.ConfirmPassword_textBox1.Location = new System.Drawing.Point(288, 190);
            this.ConfirmPassword_textBox1.Name = "ConfirmPassword_textBox1";
            this.ConfirmPassword_textBox1.PasswordChar = '*';
            this.ConfirmPassword_textBox1.Size = new System.Drawing.Size(250, 22);
            this.ConfirmPassword_textBox1.TabIndex = 14;
            this.ConfirmPassword_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Name";
            // 
            // FirstName_textBox2
            // 
            this.FirstName_textBox2.Location = new System.Drawing.Point(288, 232);
            this.FirstName_textBox2.Name = "FirstName_textBox2";
            this.FirstName_textBox2.Size = new System.Drawing.Size(250, 22);
            this.FirstName_textBox2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // LastName_textBox3
            // 
            this.LastName_textBox3.Location = new System.Drawing.Point(288, 278);
            this.LastName_textBox3.Name = "LastName_textBox3";
            this.LastName_textBox3.Size = new System.Drawing.Size(250, 22);
            this.LastName_textBox3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email Address";
            // 
            // EmailAddress_textBox4
            // 
            this.EmailAddress_textBox4.Location = new System.Drawing.Point(288, 328);
            this.EmailAddress_textBox4.Name = "EmailAddress_textBox4";
            this.EmailAddress_textBox4.Size = new System.Drawing.Size(250, 22);
            this.EmailAddress_textBox4.TabIndex = 20;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailAddress_textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName_textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName_textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmPassword_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAccount_button1);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_textbox1);
            this.Controls.Add(this.Username_textbox1);
            this.Controls.Add(this.CreateNewUserAccount_label);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateNewUserAccount_label;
        private System.Windows.Forms.Button CreateAccount_button1;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Password_textbox1;
        private System.Windows.Forms.TextBox Username_textbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmPassword_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName_textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName_textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailAddress_textBox4;
    }
}