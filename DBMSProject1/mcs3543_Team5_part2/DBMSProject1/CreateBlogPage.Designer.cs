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
            this.AddTag_button = new System.Windows.Forms.Button();
            this.PostBlog_button1 = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.RemoveTag = new System.Windows.Forms.Button();
            this.TagsLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(378, 47);
            this.Welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(369, 61);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "Create A Blog!";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(136, 128);
            this.subjectBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subjectBox.MaxLength = 150;
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(896, 31);
            this.subjectBox.TabIndex = 3;
            this.subjectBox.TextChanged += new System.EventHandler(this.subjectBox_TextChanged);
            // 
            // AddTag_button
            // 
            this.AddTag_button.Location = new System.Drawing.Point(646, 512);
            this.AddTag_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTag_button.Name = "AddTag_button";
            this.AddTag_button.Size = new System.Drawing.Size(112, 48);
            this.AddTag_button.TabIndex = 4;
            this.AddTag_button.Text = "Add Tag";
            this.AddTag_button.UseVisualStyleBackColor = true;
            this.AddTag_button.Click += new System.EventHandler(this.AddTag_button_Click);
            // 
            // PostBlog_button1
            // 
            this.PostBlog_button1.Location = new System.Drawing.Point(1018, 627);
            this.PostBlog_button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PostBlog_button1.Name = "PostBlog_button1";
            this.PostBlog_button1.Size = new System.Drawing.Size(160, 56);
            this.PostBlog_button1.TabIndex = 5;
            this.PostBlog_button1.Text = "Post Blog";
            this.PostBlog_button1.UseVisualStyleBackColor = true;
            this.PostBlog_button1.Click += new System.EventHandler(this.PostBlog_button1_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(136, 209);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.descriptionBox.MaxLength = 250;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(896, 207);
            this.descriptionBox.TabIndex = 6;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(24, 23);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 44);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1046, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1048, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(136, 514);
            this.tagBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tagBox.MaxLength = 19;
            this.tagBox.Multiline = true;
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(468, 45);
            this.tagBox.TabIndex = 10;
            this.tagBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RemoveTag
            // 
            this.RemoveTag.Location = new System.Drawing.Point(843, 512);
            this.RemoveTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveTag.Name = "RemoveTag";
            this.RemoveTag.Size = new System.Drawing.Size(192, 48);
            this.RemoveTag.TabIndex = 11;
            this.RemoveTag.Text = "Remove all tags";
            this.RemoveTag.UseVisualStyleBackColor = true;
            this.RemoveTag.Click += new System.EventHandler(this.RemoveTag_Click);
            // 
            // TagsLabel
            // 
            this.TagsLabel.AutoSize = true;
            this.TagsLabel.Location = new System.Drawing.Point(136, 452);
            this.TagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(0, 25);
            this.TagsLabel.TabIndex = 12;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(136, 627);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 25);
            this.errorLabel.TabIndex = 13;
            // 
            // CreateBlogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.TagsLabel);
            this.Controls.Add(this.RemoveTag);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.PostBlog_button1);
            this.Controls.Add(this.AddTag_button);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.Welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateBlogPage";
            this.Text = "CreateBlogPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Button AddTag_button;
        private System.Windows.Forms.Button PostBlog_button1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Button RemoveTag;
        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}