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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropDown_comboBox1
            // 
            this.DropDown_comboBox1.FormattingEnabled = true;
            this.DropDown_comboBox1.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.DropDown_comboBox1.Location = new System.Drawing.Point(765, 495);
            this.DropDown_comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropDown_comboBox1.MaxDropDownItems = 2;
            this.DropDown_comboBox1.Name = "DropDown_comboBox1";
            this.DropDown_comboBox1.Size = new System.Drawing.Size(168, 33);
            this.DropDown_comboBox1.TabIndex = 1;
            this.DropDown_comboBox1.SelectedIndexChanged += new System.EventHandler(this.DropDown_comboBox1_SelectedIndexChanged);
            // 
            // Subject_textBox1
            // 
            this.Subject_textBox1.Location = new System.Drawing.Point(263, 101);
            this.Subject_textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Subject_textBox1.Name = "Subject_textBox1";
            this.Subject_textBox1.ReadOnly = true;
            this.Subject_textBox1.Size = new System.Drawing.Size(541, 31);
            this.Subject_textBox1.TabIndex = 2;
            this.Subject_textBox1.Text = "Subject";
            this.Subject_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Subject_textBox1.TextChanged += new System.EventHandler(this.Subject_textBox1_TextChanged);
            // 
            // Tags_textBox2
            // 
            this.Tags_textBox2.Location = new System.Drawing.Point(318, 340);
            this.Tags_textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tags_textBox2.Name = "Tags_textBox2";
            this.Tags_textBox2.ReadOnly = true;
            this.Tags_textBox2.Size = new System.Drawing.Size(422, 31);
            this.Tags_textBox2.TabIndex = 3;
            this.Tags_textBox2.Text = "Tags";
            this.Tags_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(312, 482);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 148);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Description_TextBox2
            // 
            this.Description_TextBox2.Location = new System.Drawing.Point(191, 165);
            this.Description_TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Description_TextBox2.Name = "Description_TextBox2";
            this.Description_TextBox2.ReadOnly = true;
            this.Description_TextBox2.Size = new System.Drawing.Size(732, 148);
            this.Description_TextBox2.TabIndex = 6;
            this.Description_TextBox2.Text = "Description";
            // 
            // Post_button
            // 
            this.Post_button.Location = new System.Drawing.Point(765, 570);
            this.Post_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Post_button.Name = "Post_button";
            this.Post_button.Size = new System.Drawing.Size(158, 36);
            this.Post_button.TabIndex = 7;
            this.Post_button.Text = "Post";
            this.Post_button.UseVisualStyleBackColor = true;
            this.Post_button.Click += new System.EventHandler(this.Post_button_Click);
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(396, 14);
            this.Welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(269, 61);
            this.Welcome_label.TabIndex = 8;
            this.Welcome_label.Text = "Blog Page";
            this.Welcome_label.Click += new System.EventHandler(this.Welcome_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 691);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "_";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // CommentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1042);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.Post_button);
            this.Controls.Add(this.Description_TextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Tags_textBox2);
            this.Controls.Add(this.Subject_textBox1);
            this.Controls.Add(this.DropDown_comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}