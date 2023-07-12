namespace Library_project_UI
{
    partial class Login
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
            label1 = new Label();
            UserRadioButton = new RadioButton();
            LibrarianRadioButton = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "Im a:";
            // 
            // UserRadioButton
            // 
            UserRadioButton.AutoSize = true;
            UserRadioButton.Location = new Point(175, 47);
            UserRadioButton.Name = "UserRadioButton";
            UserRadioButton.Size = new Size(72, 29);
            UserRadioButton.TabIndex = 1;
            UserRadioButton.TabStop = true;
            UserRadioButton.Text = "User";
            UserRadioButton.UseVisualStyleBackColor = true;
            // 
            // LibrarianRadioButton
            // 
            LibrarianRadioButton.AutoSize = true;
            LibrarianRadioButton.Location = new Point(253, 47);
            LibrarianRadioButton.Name = "LibrarianRadioButton";
            LibrarianRadioButton.Size = new Size(104, 29);
            LibrarianRadioButton.TabIndex = 2;
            LibrarianRadioButton.TabStop = true;
            LibrarianRadioButton.Text = "Librarian";
            LibrarianRadioButton.UseVisualStyleBackColor = true;
            LibrarianRadioButton.CheckedChanged += LibrarianRadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 121);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "User name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 193);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(248, 118);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(173, 31);
            UserNameTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(248, 190);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(173, 31);
            PasswordTextBox.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(217, 270);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(204, 44);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 352);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LibrarianRadioButton);
            Controls.Add(UserRadioButton);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton UserRadioButton;
        private RadioButton LibrarianRadioButton;
        private Label label2;
        private Label label3;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}