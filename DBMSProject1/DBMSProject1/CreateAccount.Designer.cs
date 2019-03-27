namespace DBMSProject1
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
            this.CreateAccount_button1.Location = new System.Drawing.Point(338, 241);
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
            this.Password_label.Location = new System.Drawing.Point(182, 188);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(100, 17);
            this.Password_label.TabIndex = 10;
            this.Password_label.Text = "New Password";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(178, 144);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(104, 17);
            this.Username_label.TabIndex = 9;
            this.Username_label.Text = "New Username";
            // 
            // Password_textbox1
            // 
            this.Password_textbox1.Location = new System.Drawing.Point(288, 185);
            this.Password_textbox1.Name = "Password_textbox1";
            this.Password_textbox1.Size = new System.Drawing.Size(250, 22);
            this.Password_textbox1.TabIndex = 8;
            // 
            // Username_textbox1
            // 
            this.Username_textbox1.Location = new System.Drawing.Point(288, 144);
            this.Username_textbox1.Name = "Username_textbox1";
            this.Username_textbox1.Size = new System.Drawing.Size(250, 22);
            this.Username_textbox1.TabIndex = 7;
            this.Username_textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}