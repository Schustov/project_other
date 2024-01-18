using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bars
{
    public partial class Form1 : Form { 
        int currentBtnsCount = 0;
        int totalBtnsCount = 0;
        Panel panel = new Panel();
        public Form1() {
            InitializeComponent();
            CreatePanel();
            AddButton("Добавить кнопку");
            Title();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void CreatePanel() {
            panel.Size = new Size(Width-15, Height-40);
            panel.AutoScroll = true;
            Controls.Add(panel);
        }
        private void AddButton(string buttonText) {
            currentBtnsCount += 1;
            totalBtnsCount += 1;
            Title();
            Button myButton = new Button();
            myButton.Text = buttonText;
            myButton.Size = new Size(Width-15, 30);
            myButton.Click += btn_Click;
            if (panel.Controls.Count >= 1) {
                myButton.Location = new Point(panel.Controls[panel.Controls.Count-1].Location.X,
                    panel.Controls[panel.Controls.Count - 1].Location.Y + 30);
            }         
            panel.Controls.Add(myButton);
            
        }
        private void btn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            if (btn.Text == "Добавить кнопку") {
                panel.Controls[panel.Controls.Count - 1].Text = "Удалить эту кнопку";
                AddButton("Добавить кнопку");
            } else {
                currentBtnsCount -= 1;
                Title();
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
                panel.Controls[panel.Controls.Count - 1].Text = "Добавить кнопку";
            }
            
        }
        private string GetSuffix(int b) {
            if (b % 100 >= 11 && b % 100 <= 20) return "батончиков";
            else if (b % 10 == 1) return "батончик";
            else if (b % 10 == 2 || b % 10 == 3 || b % 10 == 4) return "батончика";
            else return "батончиков";
        }
        private void Title() {
            this.Text = $"Сейчас существует: {currentBtnsCount} {GetSuffix(currentBtnsCount)}," +
                $" а всего было: {totalBtnsCount} {GetSuffix(totalBtnsCount)}";
        }
        private void Form1_Resize(object sender, EventArgs e) { 
            panel.Size = new Size(Width-15, Height-40);
            foreach (Control p in panel.Controls)
                if (p is Button) p.Size = new Size(Width-15, 30);
        }
    }
}
