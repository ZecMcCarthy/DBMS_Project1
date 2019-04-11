namespace DBMSProject1
{
    partial class CreateBlogPage
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
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.AddTag_button1 = new System.Windows.Forms.Button();
            this.PostBlog_button1 = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(252, 30);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(229, 38);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "Create A Blog!";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(91, 82);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(599, 22);
            this.subjectBox.TabIndex = 3;
            this.subjectBox.TextChanged += new System.EventHandler(this.subjectBox_TextChanged);
            // 
            // AddTag_button1
            // 
            this.AddTag_button1.Location = new System.Drawing.Point(431, 328);
            this.AddTag_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTag_button1.Name = "AddTag_button1";
            this.AddTag_button1.Size = new System.Drawing.Size(75, 31);
            this.AddTag_button1.TabIndex = 4;
            this.AddTag_button1.Text = "Add Tag";
            this.AddTag_button1.UseVisualStyleBackColor = true;
            // 
            // PostBlog_button1
            // 
            this.PostBlog_button1.Location = new System.Drawing.Point(679, 401);
            this.PostBlog_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostBlog_button1.Name = "PostBlog_button1";
            this.PostBlog_button1.Size = new System.Drawing.Size(107, 36);
            this.PostBlog_button1.TabIndex = 5;
            this.PostBlog_button1.Text = "Post Blog";
            this.PostBlog_button1.UseVisualStyleBackColor = true;
            this.PostBlog_button1.Click += new System.EventHandler(this.PostBlog_button1_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(91, 134);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(599, 134);
            this.descriptionBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(91, 329);
            this.tagBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagBox.Multiline = true;
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(313, 30);
            this.tagBox.TabIndex = 10;
            this.tagBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remove all tags";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreateBlogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.PostBlog_button1);
            this.Controls.Add(this.AddTag_button1);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.Welcome_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateBlogPage";
            this.Text = "CreateBlogPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Button AddTag_button1;
        private System.Windows.Forms.Button PostBlog_button1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Button button2;
    }
}