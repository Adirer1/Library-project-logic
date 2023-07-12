namespace Library_project_UI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            ItemsListBox = new ListBox();
            ItemListSearchBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.None;
            AddButton.Location = new Point(182, 101);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(198, 38);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.None;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(571, 173);
            ItemsListBox.Margin = new Padding(2);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(250, 304);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            ItemsListBox.DoubleClick += ItemsListBox_DoubleClick;
            ItemsListBox.KeyDown += ItemsListBox_KeyDown;
            ItemsListBox.KeyPress += ItemsListBox_KeyDown;
            // 
            // ItemListSearchBox
            // 
            ItemListSearchBox.Anchor = AnchorStyles.None;
            ItemListSearchBox.Location = new Point(571, 101);
            ItemListSearchBox.Margin = new Padding(2);
            ItemListSearchBox.Multiline = true;
            ItemListSearchBox.Name = "ItemListSearchBox";
            ItemListSearchBox.Size = new Size(250, 38);
            ItemListSearchBox.TabIndex = 2;
            ItemListSearchBox.TextChanged += ItemListSearchBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(571, 73);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EnchantingTable;
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1057, 549);
            Controls.Add(label1);
            Controls.Add(ItemListSearchBox);
            Controls.Add(ItemsListBox);
            Controls.Add(AddButton);
            Margin = new Padding(2);
            Name = "Main";
            Text = "Library system";
            Load += Main_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private ListBox ItemsListBox;
        private TextBox ItemListSearchBox;
        private Label label1;
    }
}