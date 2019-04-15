namespace DBMSProject1
{
    partial class WelcomePage
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
            this.Welcome_label = new System.Windows.Forms.Label();
            this.CreateBlog_button1 = new System.Windows.Forms.Button();
            this.SearchBlog_textBox = new System.Windows.Forms.TextBox();
            this.SearchBlog_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(441, 39);
            this.Welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(248, 61);
            this.Welcome_label.TabIndex = 1;
            this.Welcome_label.Text = "Welcome";
            // 
            // CreateBlog_button1
            // 
            this.CreateBlog_button1.Location = new System.Drawing.Point(478, 359);
            this.CreateBlog_button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateBlog_button1.Name = "CreateBlog_button1";
            this.CreateBlog_button1.Size = new System.Drawing.Size(154, 59);
            this.CreateBlog_button1.TabIndex = 2;
            this.CreateBlog_button1.Text = "Create Blog";
            this.CreateBlog_button1.UseVisualStyleBackColor = true;
            this.CreateBlog_button1.Click += new System.EventHandler(this.CreateBlog_button1_Click);
            // 
            // SearchBlog_textBox
            // 
            this.SearchBlog_textBox.Location = new System.Drawing.Point(384, 244);
            this.SearchBlog_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBlog_textBox.Name = "SearchBlog_textBox";
            this.SearchBlog_textBox.Size = new System.Drawing.Size(364, 31);
            this.SearchBlog_textBox.TabIndex = 3;
            this.SearchBlog_textBox.TextChanged += new System.EventHandler(this.SearchBlog_textBox_TextChanged);
            // 
            // SearchBlog_button
            // 
            this.SearchBlog_button.Location = new System.Drawing.Point(220, 231);
            this.SearchBlog_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBlog_button.Name = "SearchBlog_button";
            this.SearchBlog_button.Size = new System.Drawing.Size(154, 59);
            this.SearchBlog_button.TabIndex = 4;
            this.SearchBlog_button.Text = "Search Blog";
            this.SearchBlog_button.UseVisualStyleBackColor = true;
            this.SearchBlog_button.Click += new System.EventHandler(this.SearchBlog_button_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.SearchBlog_button);
            this.Controls.Add(this.SearchBlog_textBox);
            this.Controls.Add(this.CreateBlog_button1);
            this.Controls.Add(this.Welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Button CreateBlog_button1;
        private System.Windows.Forms.TextBox SearchBlog_textBox;
        private System.Windows.Forms.Button SearchBlog_button;
    }
}