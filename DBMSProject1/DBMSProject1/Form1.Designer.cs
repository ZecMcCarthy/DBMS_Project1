namespace DBMSProject1
{
    partial class GUI
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
            this.Inititalize_button = new System.Windows.Forms.Button();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Signin_button = new System.Windows.Forms.Button();
            this.CreatAccount_button = new System.Windows.Forms.Button();
            this.CreateNewUserAccount_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inititalize_button
            // 
            this.Inititalize_button.Location = new System.Drawing.Point(18, 19);
            this.Inititalize_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inititalize_button.Name = "Inititalize_button";
            this.Inititalize_button.Size = new System.Drawing.Size(177, 84);
            this.Inititalize_button.TabIndex = 0;
            this.Inititalize_button.Text = "Initialize Data";
            this.Inititalize_button.UseVisualStyleBackColor = true;
            this.Inititalize_button.Click += new System.EventHandler(this.Inititalize_button_Click);
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(417, 270);
            this.Username_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(373, 31);
            this.Username_textbox.TabIndex = 1;
            this.Username_textbox.TextChanged += new System.EventHandler(this.Username_textbox_TextChanged);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(417, 334);
            this.Password_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(373, 31);
            this.Password_textbox.TabIndex = 2;
            this.Password_textbox.TextChanged += new System.EventHandler(this.Password_textbox_TextChanged);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(298, 270);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(110, 25);
            this.Username_label.TabIndex = 3;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(298, 339);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(106, 25);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            this.Password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Signin_button
            // 
            this.Signin_button.Location = new System.Drawing.Point(378, 416);
            this.Signin_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Signin_button.Name = "Signin_button";
            this.Signin_button.Size = new System.Drawing.Size(158, 58);
            this.Signin_button.TabIndex = 5;
            this.Signin_button.Text = "Sign In";
            this.Signin_button.UseVisualStyleBackColor = true;
            this.Signin_button.Click += new System.EventHandler(this.Signin_button_Click);
            // 
            // CreatAccount_button
            // 
            this.CreatAccount_button.Location = new System.Drawing.Point(591, 416);
            this.CreatAccount_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreatAccount_button.Name = "CreatAccount_button";
            this.CreatAccount_button.Size = new System.Drawing.Size(201, 58);
            this.CreatAccount_button.TabIndex = 6;
            this.CreatAccount_button.Text = "Create Account";
            this.CreatAccount_button.UseVisualStyleBackColor = true;
            this.CreatAccount_button.Click += new System.EventHandler(this.CreatAccount_button_Click);
            // 
            // CreateNewUserAccount_label
            // 
            this.CreateNewUserAccount_label.AutoSize = true;
            this.CreateNewUserAccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewUserAccount_label.Location = new System.Drawing.Point(345, 108);
            this.CreateNewUserAccount_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateNewUserAccount_label.Name = "CreateNewUserAccount_label";
            this.CreateNewUserAccount_label.Size = new System.Drawing.Size(484, 61);
            this.CreateNewUserAccount_label.TabIndex = 7;
            this.CreateNewUserAccount_label.Text = "Enter User Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(288, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNewUserAccount_label);
            this.Controls.Add(this.CreatAccount_button);
            this.Controls.Add(this.Signin_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Inititalize_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inititalize_button;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Signin_button;
        private System.Windows.Forms.Button CreatAccount_button;
        private System.Windows.Forms.Label CreateNewUserAccount_label;
        private System.Windows.Forms.Label label1;
    }
}

