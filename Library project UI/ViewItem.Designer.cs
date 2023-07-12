namespace Library_project_UI
{
    partial class ViewItem
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
            TypeBox = new TextBox();
            AuthorBox = new TextBox();
            TitleBox = new TextBox();
            GenreBox = new TextBox();
            PublisherBox = new TextBox();
            PriceBox = new TextBox();
            PublishDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            SaveButton = new Button();
            DeleteButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // TypeBox
            // 
            TypeBox.Location = new Point(198, 60);
            TypeBox.Name = "TypeBox";
            TypeBox.ReadOnly = true;
            TypeBox.Size = new Size(264, 39);
            TypeBox.TabIndex = 0;
            TypeBox.TabStop = false;
            TypeBox.TextChanged += textBox1_TextChanged;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(122, 185);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(340, 39);
            AuthorBox.TabIndex = 1;
            AuthorBox.TextChanged += AuthorBox_TextChanged;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(122, 309);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(340, 39);
            TitleBox.TabIndex = 2;
            // 
            // GenreBox
            // 
            GenreBox.Location = new Point(122, 445);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(340, 39);
            GenreBox.TabIndex = 3;
            // 
            // PublisherBox
            // 
            PublisherBox.Location = new Point(122, 573);
            PublisherBox.Name = "PublisherBox";
            PublisherBox.Size = new Size(340, 39);
            PublisherBox.TabIndex = 4;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(122, 841);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(150, 39);
            PriceBox.TabIndex = 6;
            // 
            // PublishDatePicker
            // 
            PublishDatePicker.Location = new Point(122, 704);
            PublishDatePicker.Name = "PublishDatePicker";
            PublishDatePicker.Size = new Size(340, 39);
            PublishDatePicker.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 150);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 8;
            label1.Text = "Author:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 274);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 10;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 410);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 11;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 538);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 12;
            label4.Text = "Publisher:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 669);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 15;
            label6.Text = "Publish date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 806);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 16;
            label5.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 60);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 17;
            label7.Text = "Type:";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.YellowGreen;
            SaveButton.Location = new Point(546, 60);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(192, 64);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Maroon;
            DeleteButton.ForeColor = SystemColors.ButtonHighlight;
            DeleteButton.Location = new Point(778, 60);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(196, 64);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(726, 824);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(288, 80);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ViewItem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 920);
            Controls.Add(CancelButton);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PublishDatePicker);
            Controls.Add(PriceBox);
            Controls.Add(PublisherBox);
            Controls.Add(GenreBox);
            Controls.Add(TitleBox);
            Controls.Add(AuthorBox);
            Controls.Add(TypeBox);
            Margin = new Padding(4);
            Name = "ViewItem";
            Text = "View";
            Load += ViewItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TypeBox;
        private TextBox AuthorBox;
        private TextBox TitleBox;
        private TextBox GenreBox;
        private TextBox PublisherBox;
        private TextBox PriceBox;
        private DateTimePicker PublishDatePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button SaveButton;
        private Button DeleteButton;
        private Button CancelButton;
    }
}