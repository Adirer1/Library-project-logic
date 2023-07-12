namespace Library_project_UI
{
    partial class SureDelete
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
            NoButton = new Button();
            YesButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 43);
            label1.Name = "label1";
            label1.Size = new Size(562, 50);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to delete?";
            label1.Click += label1_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new Point(106, 159);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(248, 68);
            NoButton.TabIndex = 1;
            NoButton.Text = "No";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // YesButton
            // 
            YesButton.Location = new Point(426, 159);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(248, 68);
            YesButton.TabIndex = 2;
            YesButton.Text = "Yes";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += button2_Click;
            // 
            // SureDelete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 258);
            Controls.Add(YesButton);
            Controls.Add(NoButton);
            Controls.Add(label1);
            Name = "SureDelete";
            Text = "Delete";
            Load += SureDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button NoButton;
        private Button YesButton;
    }
}