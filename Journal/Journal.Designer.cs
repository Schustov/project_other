namespace Journal
{
    partial class Journal
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
            studentLabel = new Label();
            fullNameInput = new TextBox();
            label1 = new Label();
            addButton = new Button();
            marksGridView = new DataGridView();
            Mathematics = new DataGridViewTextBoxColumn();
            Biology = new DataGridViewTextBoxColumn();
            Practice = new DataGridViewTextBoxColumn();
            removeButton = new Button();
            studentInput = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)marksGridView).BeginInit();
            SuspendLayout();
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(12, 15);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(53, 15);
            studentLabel.TabIndex = 3;
            studentLabel.Text = "Студент:";
            // 
            // fullNameInput
            // 
            fullNameInput.Location = new Point(97, 95);
            fullNameInput.Name = "fullNameInput";
            fullNameInput.Size = new Size(294, 23);
            fullNameInput.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 9;
            label1.Text = "Полное имя:";
            // 
            // addButton
            // 
            addButton.Location = new Point(397, 94);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // marksGridView
            // 
            marksGridView.AllowUserToAddRows = false;
            marksGridView.AllowUserToDeleteRows = false;
            marksGridView.BorderStyle = BorderStyle.None;
            marksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            marksGridView.Columns.AddRange(new DataGridViewColumn[] { Mathematics, Biology, Practice });
            marksGridView.Location = new Point(12, 41);
            marksGridView.Name = "marksGridView";
            marksGridView.Size = new Size(460, 48);
            marksGridView.TabIndex = 11;
            marksGridView.CellFormatting += marksGridView_CellFormatting;
            // 
            // Mathematics
            // 
            Mathematics.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mathematics.DataPropertyName = "Mathematics";
            Mathematics.HeaderText = "Математика";
            Mathematics.MaxInputLength = 1;
            Mathematics.Name = "Mathematics";
            // 
            // Biology
            // 
            Biology.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Biology.DataPropertyName = "Biology";
            Biology.HeaderText = "Биология";
            Biology.MaxInputLength = 1;
            Biology.Name = "Biology";
            // 
            // Practice
            // 
            Practice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Practice.DataPropertyName = "Practice";
            Practice.HeaderText = "Практика";
            Practice.MaxInputLength = 1;
            Practice.Name = "Practice";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(397, 11);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 12;
            removeButton.Text = "Отчислить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // studentInput
            // 
            studentInput.DropDownStyle = ComboBoxStyle.DropDownList;
            studentInput.FormattingEnabled = true;
            studentInput.Location = new Point(71, 12);
            studentInput.Name = "studentInput";
            studentInput.Size = new Size(320, 23);
            studentInput.TabIndex = 0;
            studentInput.SelectedValueChanged += studentInput_SelectedValueChanged;
            // 
            // Journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 131);
            Controls.Add(removeButton);
            Controls.Add(marksGridView);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(fullNameInput);
            Controls.Add(studentLabel);
            Controls.Add(studentInput);
            MaximizeBox = false;
            MaximumSize = new Size(500, 170);
            MinimumSize = new Size(500, 170);
            Name = "Journal";
            Text = "Журнал";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)marksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label studentLabel;
        private TextBox fullNameInput;
        private Label label1;
        private Button addButton;
        private DataGridView marksGridView;
        private Button removeButton;
        private ComboBox studentInput;
        private DataGridViewTextBoxColumn Mathematics;
        private DataGridViewTextBoxColumn Biology;
        private DataGridViewTextBoxColumn Practice;
    }
}
