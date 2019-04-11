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
            this.AddTag_textBox1 = new System.Windows.Forms.TextBox();
            this.AddTag_button1 = new System.Windows.Forms.Button();
            this.PostBlog_button1 = new System.Windows.Forms.Button();
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
            // AddTag_textBox1
            // 
            this.AddTag_textBox1.Location = new System.Drawing.Point(274, 115);
            this.AddTag_textBox1.Name = "AddTag_textBox1";
            this.AddTag_textBox1.Size = new System.Drawing.Size(175, 22);
            this.AddTag_textBox1.TabIndex = 3;
            // 
            // AddTag_button1
            // 
            this.AddTag_button1.Location = new System.Drawing.Point(480, 111);
            this.AddTag_button1.Name = "AddTag_button1";
            this.AddTag_button1.Size = new System.Drawing.Size(75, 31);
            this.AddTag_button1.TabIndex = 4;
            this.AddTag_button1.Text = "Add Tag";
            this.AddTag_button1.UseVisualStyleBackColor = true;
            // 
            // PostBlog_button1
            // 
            this.PostBlog_button1.Location = new System.Drawing.Point(311, 189);
            this.PostBlog_button1.Name = "PostBlog_button1";
            this.PostBlog_button1.Size = new System.Drawing.Size(107, 23);
            this.PostBlog_button1.TabIndex = 5;
            this.PostBlog_button1.Text = "Post Blog";
            this.PostBlog_button1.UseVisualStyleBackColor = true;
            // 
            // CreateBlogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PostBlog_button1);
            this.Controls.Add(this.AddTag_button1);
            this.Controls.Add(this.AddTag_textBox1);
            this.Controls.Add(this.Welcome_label);
            this.Name = "CreateBlogPage";
            this.Text = "CreateBlogPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.TextBox AddTag_textBox1;
        private System.Windows.Forms.Button AddTag_button1;
        private System.Windows.Forms.Button PostBlog_button1;
    }
}