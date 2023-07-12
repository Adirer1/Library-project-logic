namespace Library_project_UI
{
    partial class AddButton
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
            PriceBox = new TextBox();
            MagazineButton = new RadioButton();
            BookButton = new RadioButton();
            AuthorBox = new TextBox();
            label1 = new Label();
            PublisherBox = new TextBox();
            TitleBox = new TextBox();
            GenreBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            PublishDatePicker = new DateTimePicker();
            label6 = new Label();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(86, 596);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(184, 39);
            PriceBox.TabIndex = 8;
            // 
            // MagazineButton
            // 
            MagazineButton.AutoSize = true;
            MagazineButton.Location = new Point(413, 28);
            MagazineButton.Name = "MagazineButton";
            MagazineButton.Size = new Size(149, 36);
            MagazineButton.TabIndex = 2;
            MagazineButton.TabStop = true;
            MagazineButton.Text = "Magazine";
            MagazineButton.UseVisualStyleBackColor = true;
            MagazineButton.CheckedChanged += MagazineButton_CheckedChanged;
            // 
            // BookButton
            // 
            BookButton.AutoSize = true;
            BookButton.Location = new Point(257, 28);
            BookButton.Name = "BookButton";
            BookButton.Size = new Size(99, 36);
            BookButton.TabIndex = 1;
            BookButton.TabStop = true;
            BookButton.Text = "Book";
            BookButton.UseVisualStyleBackColor = true;
            BookButton.CheckedChanged += BookButton_CheckedChanged;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(86, 96);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(300, 39);
            AuthorBox.TabIndex = 3;
            AuthorBox.TextChanged += AuthorBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 61);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 5;
            label1.Text = "Author:";
            // 
            // PublisherBox
            // 
            PublisherBox.Location = new Point(86, 398);
            PublisherBox.Name = "PublisherBox";
            PublisherBox.Size = new Size(632, 39);
            PublisherBox.TabIndex = 6;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(84, 198);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(632, 39);
            TitleBox.TabIndex = 4;
            // 
            // GenreBox
            // 
            GenreBox.Location = new Point(84, 292);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(632, 39);
            GenreBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 163);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 9;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 257);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 10;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 364);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 11;
            label4.Text = "Publisher:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 561);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 12;
            label5.Text = "Price:";
            // 
            // PublishDatePicker
            // 
            PublishDatePicker.Location = new Point(206, 503);
            PublishDatePicker.Name = "PublishDatePicker";
            PublishDatePicker.Size = new Size(400, 39);
            PublishDatePicker.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 468);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 14;
            label6.Text = "Publish date:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(292, 654);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(176, 79);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddButton
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 762);
            Controls.Add(SaveButton);
            Controls.Add(label6);
            Controls.Add(PublishDatePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GenreBox);
            Controls.Add(TitleBox);
            Controls.Add(PublisherBox);
            Controls.Add(label1);
            Controls.Add(AuthorBox);
            Controls.Add(BookButton);
            Controls.Add(MagazineButton);
            Controls.Add(PriceBox);
            Name = "AddButton";
            Text = "Add item:";
            Load += AddButton_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PriceBox;
        private RadioButton MagazineButton;
        private RadioButton BookButton;
        private TextBox AuthorBox;
        private Label label1;
        private TextBox PublisherBox;
        private TextBox TitleBox;
        private TextBox GenreBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker PublishDatePicker;
        private Label label6;
        private Button SaveButton;
    }
}