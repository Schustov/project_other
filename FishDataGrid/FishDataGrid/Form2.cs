using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FishDataGrid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void TextBoxFish_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxWeight.Text != string.Empty && TextBoxShelfLife.Text != string.Empty)
            {
                Form1.booln = true;
                Close();
            }
            else
            {
                MessageBox.Show("Не заполнены поля");
                Form1.booln = false;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Form1.booln = false;
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
