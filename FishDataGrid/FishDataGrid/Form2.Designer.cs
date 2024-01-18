namespace FishDataGrid
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.LabelFish = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.TextBoxShelfLife = new System.Windows.Forms.TextBox();
            this.LabelShelfLife = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.LabelWeight = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelFish
            // 
            this.LabelFish.AutoSize = true;
            this.LabelFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFish.Location = new System.Drawing.Point(66, 19);
            this.LabelFish.Name = "LabelFish";
            this.LabelFish.Size = new System.Drawing.Size(103, 24);
            this.LabelFish.TabIndex = 0;
            this.LabelFish.Text = "Вид рыбы:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDate.Location = new System.Drawing.Point(66, 88);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(130, 24);
            this.LabelDate.TabIndex = 2;
            this.LabelDate.Text = "Дата вылова:";
            // 
            // TextBoxShelfLife
            // 
            this.TextBoxShelfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxShelfLife.Location = new System.Drawing.Point(70, 188);
            this.TextBoxShelfLife.Name = "TextBoxShelfLife";
            this.TextBoxShelfLife.Size = new System.Drawing.Size(207, 29);
            this.TextBoxShelfLife.TabIndex = 5;
            // 
            // LabelShelfLife
            // 
            this.LabelShelfLife.AutoSize = true;
            this.LabelShelfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelShelfLife.Location = new System.Drawing.Point(66, 161);
            this.LabelShelfLife.Name = "LabelShelfLife";
            this.LabelShelfLife.Size = new System.Drawing.Size(149, 24);
            this.LabelShelfLife.TabIndex = 4;
            this.LabelShelfLife.Text = "Срок хранения:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 29);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxWeight.Location = new System.Drawing.Point(70, 258);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(207, 29);
            this.TextBoxWeight.TabIndex = 8;
            // 
            // LabelWeight
            // 
            this.LabelWeight.AutoSize = true;
            this.LabelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWeight.Location = new System.Drawing.Point(66, 231);
            this.LabelWeight.Name = "LabelWeight";
            this.LabelWeight.Size = new System.Drawing.Size(106, 24);
            this.LabelWeight.TabIndex = 7;
            this.LabelWeight.Text = "Масса (кг):";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOK.Location = new System.Drawing.Point(20, 311);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(155, 36);
            this.ButtonOK.TabIndex = 9;
            this.ButtonOK.Text = "&Добавить";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(181, 311);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(155, 36);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "&Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Щука",
            "Окунь"});
            this.comboBox1.Location = new System.Drawing.Point(70, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 32);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fishBindingSource
            // 
            this.fishBindingSource.DataSource = typeof(FishDataGrid.Fish);
            // 
            // Form2
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(348, 366);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.LabelWeight);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TextBoxShelfLife);
            this.Controls.Add(this.LabelShelfLife);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelFish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fishBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFish;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelShelfLife;
        private System.Windows.Forms.Label LabelWeight;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.BindingSource fishBindingSource;
        public System.Windows.Forms.TextBox TextBoxShelfLife;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox TextBoxWeight;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}