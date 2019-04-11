namespace DBMSProject1
{
    partial class CommentsPage
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
            this.DropDown_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Subject_textBox1 = new System.Windows.Forms.TextBox();
            this.Tags_textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Description_TextBox2 = new System.Windows.Forms.RichTextBox();
            this.Post_button = new System.Windows.Forms.Button();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropDown_comboBox1
            // 
            this.DropDown_comboBox1.FormattingEnabled = true;
            this.DropDown_comboBox1.Location = new System.Drawing.Point(501, 268);
            this.DropDown_comboBox1.MaxDropDownItems = 2;
            this.DropDown_comboBox1.Name = "DropDown_comboBox1";
            this.DropDown_comboBox1.Size = new System.Drawing.Size(48, 24);
            this.DropDown_comboBox1.TabIndex = 1;
            // 
            // Subject_textBox1
            // 
            this.Subject_textBox1.Location = new System.Drawing.Point(255, 91);
            this.Subject_textBox1.Name = "Subject_textBox1";
            this.Subject_textBox1.Size = new System.Drawing.Size(196, 22);
            this.Subject_textBox1.TabIndex = 2;
            this.Subject_textBox1.Text = "Subject";
            this.Subject_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tags_textBox2
            // 
            this.Tags_textBox2.Location = new System.Drawing.Point(255, 230);
            this.Tags_textBox2.Name = "Tags_textBox2";
            this.Tags_textBox2.Size = new System.Drawing.Size(196, 22);
            this.Tags_textBox2.TabIndex = 3;
            this.Tags_textBox2.Text = "Tags";
            this.Tags_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 268);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(287, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Description_TextBox2
            // 
            this.Description_TextBox2.Location = new System.Drawing.Point(208, 119);
            this.Description_TextBox2.Name = "Description_TextBox2";
            this.Description_TextBox2.Size = new System.Drawing.Size(287, 96);
            this.Description_TextBox2.TabIndex = 6;
            this.Description_TextBox2.Text = "Description";
            // 
            // Post_button
            // 
            this.Post_button.Location = new System.Drawing.Point(302, 395);
            this.Post_button.Name = "Post_button";
            this.Post_button.Size = new System.Drawing.Size(105, 23);
            this.Post_button.TabIndex = 7;
            this.Post_button.Text = "Post";
            this.Post_button.UseVisualStyleBackColor = true;
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(264, 9);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(175, 38);
            this.Welcome_label.TabIndex = 8;
            this.Welcome_label.Text = "Comments";
            // 
            // CommentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Post_button);
            this.Controls.Add(this.Description_TextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Tags_textBox2);
            this.Controls.Add(this.Subject_textBox1);
            this.Controls.Add(this.DropDown_comboBox1);
            this.Name = "CommentsPage";
            this.Text = "CommentsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropDown_comboBox1;
        private System.Windows.Forms.TextBox Subject_textBox1;
        private System.Windows.Forms.TextBox Tags_textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Description_TextBox2;
        private System.Windows.Forms.Button Post_button;
        private System.Windows.Forms.Label Welcome_label;
    }
}