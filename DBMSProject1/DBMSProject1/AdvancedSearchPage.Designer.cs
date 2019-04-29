namespace DBMSProject1
{
    partial class AdvancedSearchPage
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
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.Slash1 = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.Slash2 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.SearchDate = new System.Windows.Forms.Button();
            this.Tag1 = new System.Windows.Forms.TextBox();
            this.Tag2 = new System.Windows.Forms.TextBox();
            this.TagSearch = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PositiveComments = new System.Windows.Forms.Button();
            this.NoComments = new System.Windows.Forms.Button();
            this.NegativeComments = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.Location = new System.Drawing.Point(194, 43);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(398, 38);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "Advanced Search Options";
            // 
            // MonthBox
            // 
            this.MonthBox.DisplayMember = "01";
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MonthBox.Location = new System.Drawing.Point(175, 187);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(72, 24);
            this.MonthBox.TabIndex = 3;
            // 
            // Slash1
            // 
            this.Slash1.AutoSize = true;
            this.Slash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slash1.Location = new System.Drawing.Point(253, 187);
            this.Slash1.Name = "Slash1";
            this.Slash1.Size = new System.Drawing.Size(14, 20);
            this.Slash1.TabIndex = 4;
            this.Slash1.Text = "/";
            // 
            // DayBox
            // 
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayBox.Location = new System.Drawing.Point(273, 187);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(72, 24);
            this.DayBox.TabIndex = 5;
            // 
            // Slash2
            // 
            this.Slash2.AutoSize = true;
            this.Slash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slash2.Location = new System.Drawing.Point(351, 187);
            this.Slash2.Name = "Slash2";
            this.Slash2.Size = new System.Drawing.Size(14, 20);
            this.Slash2.TabIndex = 6;
            this.Slash2.Text = "/";
            // 
            // YearBox
            // 
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.YearBox.Location = new System.Drawing.Point(371, 187);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(72, 24);
            this.YearBox.TabIndex = 7;
            // 
            // SearchDate
            // 
            this.SearchDate.Location = new System.Drawing.Point(550, 172);
            this.SearchDate.Name = "SearchDate";
            this.SearchDate.Size = new System.Drawing.Size(110, 50);
            this.SearchDate.TabIndex = 8;
            this.SearchDate.Text = "Search most posts on date";
            this.SearchDate.UseVisualStyleBackColor = true;
            this.SearchDate.Click += new System.EventHandler(this.SearchDate_Click);
            // 
            // Tag1
            // 
            this.Tag1.Location = new System.Drawing.Point(175, 117);
            this.Tag1.MaxLength = 19;
            this.Tag1.Name = "Tag1";
            this.Tag1.Size = new System.Drawing.Size(140, 22);
            this.Tag1.TabIndex = 9;
            // 
            // Tag2
            // 
            this.Tag2.Location = new System.Drawing.Point(350, 117);
            this.Tag2.Name = "Tag2";
            this.Tag2.Size = new System.Drawing.Size(140, 22);
            this.Tag2.TabIndex = 10;
            // 
            // TagSearch
            // 
            this.TagSearch.Location = new System.Drawing.Point(550, 117);
            this.TagSearch.Name = "TagSearch";
            this.TagSearch.Size = new System.Drawing.Size(120, 45);
            this.TagSearch.TabIndex = 11;
            this.TagSearch.Text = "Search user posts with tags";
            this.TagSearch.UseVisualStyleBackColor = true;
            this.TagSearch.Click += new System.EventHandler(this.TagSearch_Click);
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(175, 258);
            this.UserBox.MaxLength = 20;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(170, 22);
            this.UserBox.TabIndex = 12;
            // 
            // PositiveComments
            // 
            this.PositiveComments.Location = new System.Drawing.Point(550, 248);
            this.PositiveComments.Name = "PositiveComments";
            this.PositiveComments.Size = new System.Drawing.Size(140, 60);
            this.PositiveComments.TabIndex = 13;
            this.PositiveComments.Text = "Search all blogs from user with only positive comments";
            this.PositiveComments.UseVisualStyleBackColor = true;
            this.PositiveComments.Click += new System.EventHandler(this.PositiveComments_Click);
            // 
            // NoComments
            // 
            this.NoComments.Location = new System.Drawing.Point(175, 420);
            this.NoComments.Name = "NoComments";
            this.NoComments.Size = new System.Drawing.Size(140, 60);
            this.NoComments.TabIndex = 14;
            this.NoComments.Text = "Search all users who never posted a comment";
            this.NoComments.UseVisualStyleBackColor = true;
            this.NoComments.Click += new System.EventHandler(this.NoComments_Click);
            // 
            // NegativeComments
            // 
            this.NegativeComments.Location = new System.Drawing.Point(550, 420);
            this.NegativeComments.Name = "NegativeComments";
            this.NegativeComments.Size = new System.Drawing.Size(140, 60);
            this.NegativeComments.TabIndex = 15;
            this.NegativeComments.Text = "Search all users who only post negative comments";
            this.NegativeComments.UseVisualStyleBackColor = true;
            this.NegativeComments.Click += new System.EventHandler(this.NegativeComments_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(175, 559);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(412, 50);
            this.ErrorBox.TabIndex = 16;
            // 
            // AdvancedSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.NegativeComments);
            this.Controls.Add(this.NoComments);
            this.Controls.Add(this.PositiveComments);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.TagSearch);
            this.Controls.Add(this.Tag2);
            this.Controls.Add(this.Tag1);
            this.Controls.Add(this.SearchDate);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.Slash2);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.Slash1);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.Welcome_label);
            this.Name = "AdvancedSearchPage";
            this.Text = "AdvancedSearchPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.Label Slash1;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.Label Slash2;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Button SearchDate;
        private System.Windows.Forms.TextBox Tag1;
        private System.Windows.Forms.TextBox Tag2;
        private System.Windows.Forms.Button TagSearch;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Button PositiveComments;
        private System.Windows.Forms.Button NoComments;
        private System.Windows.Forms.Button NegativeComments;
        private System.Windows.Forms.Label ErrorBox;
    }
}