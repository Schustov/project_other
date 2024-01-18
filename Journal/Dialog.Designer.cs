namespace Journal
{
    partial class Dialog
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
            saveLabel = new Label();
            yesButton = new Button();
            noButton = new Button();
            SuspendLayout();
            // 
            // saveLabel
            // 
            saveLabel.AutoSize = true;
            saveLabel.Location = new Point(40, 20);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new Size(103, 15);
            saveLabel.TabIndex = 0;
            saveLabel.Text = "Сохранить файл?";
            // 
            // yesButton
            // 
            yesButton.DialogResult = DialogResult.Yes;
            yesButton.Location = new Point(94, 49);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(78, 25);
            yesButton.TabIndex = 1;
            yesButton.Text = "Да";
            yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            noButton.DialogResult = DialogResult.Cancel;
            noButton.Location = new Point(12, 49);
            noButton.Name = "noButton";
            noButton.Size = new Size(78, 25);
            noButton.TabIndex = 2;
            noButton.Text = "Нет";
            noButton.UseVisualStyleBackColor = true;
            // 
            // Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 86);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(saveLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saveLabel;
        private Button yesButton;
        private Button noButton;
    }
}