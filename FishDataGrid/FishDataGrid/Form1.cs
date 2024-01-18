using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FishDataGrid
{
    public partial class Form1 : Form
    {
        public static BindingSource bindingSource;
        internal static List<Fish> fishes;
        public static bool booln = false;
        public Form1()
        {
            InitializeComponent();
            fishes = new List<Fish>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = fishes;
            dataGridView1.DataSource = bindingSource;
            bindingSource.ResetBindings(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToLongDateString();
            label2.Text = $"Сегодня: {date}";

            dataGridView1.Columns["typeFish"].HeaderText = "Вид рыбы";
            dataGridView1.Columns["typeFish"].Width = 125;
            dataGridView1.Columns["dateCatch"].HeaderText = "Дата вылова";
            dataGridView1.Columns["dateCatch"].Width = 155;
            dataGridView1.Columns["shelflifedays"].HeaderText = "Хранение";
            dataGridView1.Columns["shelflifedays"].Width = 115;
            dataGridView1.Columns["weight"].HeaderText = "Масса";
            dataGridView1.Columns["weight"].Width = 100;
            dataGridView1.Columns["shelflife"].HeaderText = "Срок годности";
            dataGridView1.Columns["shelflife"].Width = 180;

            dataGridView1.Columns["typefish"].ReadOnly = true;
            dataGridView1.Columns["shelflife"].ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            DateTime selectedDate = form2.dateTimePicker1.Value;
            DateTime truncatedDate = DateTime.Parse(selectedDate.ToString("dd.MM.yyyy"));

            if (booln)
            {
                string ExDate = "Истек";
                DateTime newDate = truncatedDate.AddDays(Convert.ToDouble(form2.TextBoxShelfLife.Text));
                if (newDate >= DateTime.Now) {
                    ExDate = "Не истек";
                }
                fishes.Add(new Fish(form2.comboBox1.SelectedItem.ToString(), truncatedDate, form2.TextBoxShelfLife.Text, form2.TextBoxWeight.Text, ExDate));
                bindingSource.ResetBindings(true);
            }          
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            DataGridViewCell cell = dataGridView1[col, row];

            object cellValue = cell.Value;

            Fish fish = fishes[row];
            switch (col)
            {
                case 0:
                    fish.TypeFish = (string)cellValue;
                    break;
                case 1:
                    fish.DateCatch = (DateTime)cellValue;
                    goto case 4;
                case 2:
                    fish.ShelfLifeDays = (string)cellValue;
                    goto case 4;
                case 3:
                    fish.Weight = (string)cellValue;
                    break;
                case 4:
                    DateTime newDate = fish.DateCatch.AddDays(Convert.ToDouble(fish.ShelfLifeDays));
                    if (newDate >= DateTime.Now) fish.ShelfLife = "Не истек";
                    else fish.ShelfLife = "Истек";
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static void WriteToCsv(string filepath, List<Fish> result)
        {
            //using (File.Create(filepath)) { }

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ";",
            };

            using (StreamWriter streamWriter = new StreamWriter(filepath, true, Encoding.UTF8 ))
            using (CsvWriter csvWriter = new CsvWriter(streamWriter, config))
            {
                csvWriter.WriteRecords(result);
                
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var i = 0;
            List<Fish> result = new List<Fish>();
            

                foreach (Fish fish in fishes.ToArray())
                {
                    if (fish.ShelfLife == "Истек")
                    {
                        result.Add(fish);
                        fishes.RemoveAt(i);
                        bindingSource.ResetBindings(true);
                        continue;
                    }
                    i++;
                }

            WriteToCsv(@"data.csv", result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void fishBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

    
}
