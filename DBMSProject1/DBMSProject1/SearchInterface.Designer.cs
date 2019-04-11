namespace DBMSProject1
{
    partial class SearchInterface
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
            this.SearchResults_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchResults_textBox
            // 
            this.SearchResults_textBox.Location = new System.Drawing.Point(241, 201);
            this.SearchResults_textBox.Name = "SearchResults_textBox";
            this.SearchResults_textBox.Size = new System.Drawing.Size(218, 22);
            this.SearchResults_textBox.TabIndex = 0;
            // 
            // SearchInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchResults_textBox);
            this.Name = "SearchInterface";
            this.Text = "SearchInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchResults_textBox;
    }
}