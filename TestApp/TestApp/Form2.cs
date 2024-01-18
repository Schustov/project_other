using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp
{
    public partial class Form2 : Form
    {
        public Form2(string text1, string text2, string text3)
        {
            InitializeComponent();
            textBox1.Text = text1;
            textBox2.Text = text2;
            textBox3.Text = text3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                Form1.booln = true;
                Close();
            } else
            {
                MessageBox.Show("Не заполнены поля");
                Form1.booln = false;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
