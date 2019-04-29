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
            this.Inititalize_button.Location = new System.Drawing.Point(12, 12);
            this.Inititalize_button.Name = "Inititalize_button";
            this.Inititalize_button.Size = new System.Drawing.Size(118, 54);
            this.Inititalize_button.TabIndex = 0;
            this.Inititalize_button.Text = "Initialize Data";
            this.Inititalize_button.UseVisualStyleBackColor = true;
            this.Inititalize_button.Click += new System.EventHandler(this.Inititalize_button_Click);
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(278, 173);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(250, 22);
            this.Username_textbox.TabIndex = 1;
            this.Username_textbox.TextChanged += new System.EventHandler(this.Username_textbox_TextChanged);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(278, 214);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '*';
            this.Password_textbox.Size = new System.Drawing.Size(250, 22);
            this.Password_textbox.TabIndex = 2;
            this.Password_textbox.TextChanged += new System.EventHandler(this.Password_textbox_TextChanged);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(199, 173);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(73, 17);
            this.Username_label.TabIndex = 3;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(199, 217);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(69, 17);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            this.Password_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Signin_button
            // 
            this.Signin_button.Location = new System.Drawing.Point(252, 266);
            this.Signin_button.Name = "Signin_button";
            this.Signin_button.Size = new System.Drawing.Size(105, 37);
            this.Signin_button.TabIndex = 5;
            this.Signin_button.Text = "Sign In";
            this.Signin_button.UseVisualStyleBackColor = true;
            this.Signin_button.Click += new System.EventHandler(this.Signin_button_Click);
            // 
            // CreatAccount_button
            // 
            this.CreatAccount_button.Location = new System.Drawing.Point(394, 266);
            this.CreatAccount_button.Name = "CreatAccount_button";
            this.CreatAccount_button.Size = new System.Drawing.Size(134, 37);
            this.CreatAccount_button.TabIndex = 6;
            this.CreatAccount_button.Text = "Create Account";
            this.CreatAccount_button.UseVisualStyleBackColor = true;
            this.CreatAccount_button.Click += new System.EventHandler(this.CreatAccount_button_Click);
            // 
            // CreateNewUserAccount_label
            // 
            this.CreateNewUserAccount_label.AutoSize = true;
            this.CreateNewUserAccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewUserAccount_label.Location = new System.Drawing.Point(230, 69);
            this.CreateNewUserAccount_label.Name = "CreateNewUserAccount_label";
            this.CreateNewUserAccount_label.Size = new System.Drawing.Size(302, 38);
            this.CreateNewUserAccount_label.TabIndex = 7;
            this.CreateNewUserAccount_label.Text = "Enter User Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNewUserAccount_label);
            this.Controls.Add(this.CreatAccount_button);
            this.Controls.Add(this.Signin_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Inititalize_button);
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

