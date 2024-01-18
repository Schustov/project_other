using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = $"Здравствуй, {textBox1.Text}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.TextBoxN;
            textBox2.Text = Properties.Settings.Default.TextBoxH;
            textBox3.Text = Properties.Settings.Default.TextBoxW;
            trackBar1.Value = Properties.Settings.Default.trackbar1;
            trackBar2.Value = Properties.Settings.Default.trackbar2;

            label1.Text = $"Здравствуй, {textBox1.Text}";
            textBox2.MaxLength = 3;
            textBox3.MaxLength = 3;
            label9.Text = "1";
            label10.Text = "1";

            label9.Text = $"{trackBar1.Value}";
            label10.Text = $"{trackBar2.Value}";
            double repetitions = trackBar1.Value;
            double weight = trackBar2.Value;
            label11.Text = $"Формула Бжицки: {Convert.ToString(weight / (1.0278 - (0.0278 * repetitions)))} кг";
            label12.Text = $"Формула Эйпли: {Convert.ToString(weight * (1 + repetitions / 30))} кг";
            label13.Text = $"Формула Лэндера: {Convert.ToString((100 * weight) / (101.3 - 2.67123 * repetitions))} кг";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.TextLength > 0 && textBox3.TextLength > 0)
                {
                    double textHeight = Convert.ToDouble(textBox2.Text) / 100;
                    double height = textHeight * textHeight;
                    double mass = Convert.ToDouble(textBox3.Text);
                    double bmi = mass / height;
                    label5.Text = $"Твой индекс массы тела: {Math.Round(bmi, 3)}";
                    if (bmi <= 16)
                    {
                        label6.Text = "Выраженный дефицит массы тела";
                        pictureBox1.Image = Properties.Resources.small;
                    }
                    else if (bmi <= 18.5)
                    {
                        label6.Text = "Недостаточная (дефицит) масса тела";
                        pictureBox1.Image = Properties.Resources.small;
                    }
                    else if (bmi <= 25)
                    {
                        label6.Text = "Норма";
                        pictureBox1.Image = Properties.Resources.medium;
                    }
                    else if (bmi <= 30)
                    {
                        label6.Text = "Избыточная масса тела (предожирение)";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                    else if (bmi <= 35)
                    {
                        label6.Text = "Ожирение 1 степени";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                    else if (bmi <= 40)
                    {
                        label6.Text = "Ожирение 2 степени";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                    else
                    {
                        label6.Text = "Ожирение 3 степени";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.TextLength > 0 && textBox3.TextLength > 0)
                {
                    double textHeight = Convert.ToDouble(textBox2.Text) / 100;
                    double height = textHeight * textHeight;
                    double mass = Convert.ToDouble(textBox3.Text);
                    double bmi = mass / height;
                    label5.Text = $"Твой индекс массы тела: {Math.Round(bmi, 3)}";
                    if (bmi <= 16)
                    {
                        label6.Text = "Выраженный дефицит массы тела";
                        pictureBox1.Image = Properties.Resources.small;
                    }
                    else if (bmi <= 18.5)
                    {
                        label6.Text = "Недостаточная (дефицит) масса тела";
                        pictureBox1.Image = Properties.Resources.small;
                    }
                    else if (bmi <= 25)
                    {
                        label6.Text = "Норма";
                        pictureBox1.Image = Properties.Resources.medium;
                    }
                    else if (bmi <= 30)
                    {
                        label6.Text = "Избыточная масса тела (предожирение)";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                    else if (bmi <= 35)
                    {
                        label6.Text = "Ожирение 1 степени";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                    else if (bmi <= 40)
                    {
                        label6.Text = "Ожирение 2 степени";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                    else
                    {
                        label6.Text = "Ожирение 3 степени";
                        pictureBox1.Image = Properties.Resources.big;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число");
            }

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }

            base.WndProc(ref m);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = $"{trackBar1.Value}";
            double repetitions = trackBar1.Value;
            double weight = trackBar2.Value;
            label11.Text = $"Формула Бжицки: {Convert.ToString(weight / (1.0278 - (0.0278 * repetitions)))} кг";
            label12.Text = $"Формула Эйпли: {Convert.ToString(weight * (1 + repetitions / 30))} кг";
            label13.Text = $"Формула Лэндера: {Convert.ToString((100 * weight) / (101.3 - 2.67123 * repetitions))} кг";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label10.Text = $"{trackBar2.Value}";
            double repetitions = trackBar1.Value;
            double weight = trackBar2.Value;
            label11.Text = $"Формула Бжицки: {Convert.ToString(weight / (1.0278 - (0.0278 * repetitions)))} кг";
            label12.Text = $"Формула Эйпли: {Convert.ToString(weight * (1 + repetitions / 30))} кг";
            label13.Text = $"Формула Лэндера: {Convert.ToString((100 * weight) / (101.3 - 2.67123 * repetitions))} кг";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TextBoxN = textBox1.Text;
            Properties.Settings.Default.TextBoxH = textBox2.Text;
            Properties.Settings.Default.TextBoxW = textBox3.Text;
            Properties.Settings.Default.trackbar1 = trackBar1.Value;
            Properties.Settings.Default.trackbar2 = trackBar2.Value;
            Properties.Settings.Default.Save();
        }
    }
}
