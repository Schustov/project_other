using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookieClicker.Properties;

namespace CookieClicker
{
    
    public partial class Form1 : Form
    {
        int AmountMoney = 0;
        int Clicks = 1;
        int ClicksTimer = 0;
        int Common = 1;

        int Cost1 = 5;
        int Cost2 = 25;
        int Cost3 = 100;

        bool IsTimer = false;
        string[] phrases = {
            "\"Классное улучшение, брат\"",
            "\"А вот это деду нравится\"",
            "\"Уф, да ты богач\"",
            "\"С обновкой, йо\"",
            "\"Нельзя быть настолько крутым\"",
            "\"Как у тебя это получается?\"",
            "\"Ты свободен вечером?\"",
            "\"Кликай по мне чаще\""
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void ClickFunction()
        {
            AmountMoney += (Clicks * Common);
            label.Text = $"+{Clicks * Common}";
        }

        private async Task showPhrase()
        {
            Random random = new Random();
            int randomNum = random.Next(0, phrases.Length);
            label6.Visible = true;
            label6.Text = phrases[randomNum];
            await Task.Delay(3000);
            label6.Visible = false;
        }
        private async Task AnimateClick()
        {
            label.Visible = true;

            await Task.Delay(150);

            label.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AmountMoney = Settings.Default.money;
            Clicks = Settings.Default.click;
            ClicksTimer = Settings.Default.clicktimer;
            Common = Settings.Default.common;
            Cost1 = Settings.Default.cost1;
            Cost2 = Settings.Default.cost2;
            Cost3 = Settings.Default.cost3;
            IsTimer = Settings.Default.timer;
            Refresh();
            timer1.Start();
        }

        private void Save()
        {
            Settings.Default.money = AmountMoney;
            Settings.Default.click = Clicks;
            Settings.Default.clicktimer = ClicksTimer;
            Settings.Default.common = Common;
            Settings.Default.cost1 = Cost1;
            Settings.Default.cost2 = Cost2;
            Settings.Default.cost3 = Cost3;
            Settings.Default.timer = IsTimer;
            Settings.Default.Save();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void Refresh()
        {
            label1.Text = $"Счёт: ${AmountMoney}";
            label2.Text = "Улучшения:";
            label3.Text = $"Множитель клика: {Clicks}";
            button1.Text = $"${Cost1}";
            label4.Text = $"Множитель фона: {ClicksTimer}";
            button2.Text = $"${Cost2}";
            label5.Text = $"Общий множитель: {Common}";
            button3.Text = $"${Cost3}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickFunction();
            AnimateClick();
            label1.Text = $"Счёт: ${AmountMoney}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AmountMoney >= Cost1)
            {
                AmountMoney -= Cost1;
                Clicks += 1;
                Cost1 = 5 * (Clicks * Clicks);
                Refresh();
                showPhrase();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsTimer == true)
            {
                AmountMoney += (ClicksTimer * Common);
                Refresh();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (AmountMoney >= Cost2)
            {
                AmountMoney -= Cost2;
                ClicksTimer += 1;
                IsTimer = true;
                Cost2 = 25 * ((ClicksTimer + 1) * (ClicksTimer + 1));
                Refresh();
                showPhrase();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AmountMoney >= Cost3)
            {
                AmountMoney -= Cost3;
                Common += 1;
                Cost3 = 100 * (Common * Common);
                Refresh();
                showPhrase();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Settings.Default.money = 0;
            Settings.Default.click = 1;
            Settings.Default.clicktimer = 0;
            Settings.Default.common = 1;
            Settings.Default.cost1 = 5;
            Settings.Default.cost2 = 25;
            Settings.Default.cost3 = 100;
            Settings.Default.timer = false;
            Settings.Default.Save();

            AmountMoney = Settings.Default.money;
            Clicks = Settings.Default.click;
            ClicksTimer = Settings.Default.clicktimer;
            Common = Settings.Default.common;
            Cost1 = Settings.Default.cost1;
            Cost2 = Settings.Default.cost2;
            Cost3 = Settings.Default.cost3;
            IsTimer = Settings.Default.timer;

            label6.Visible = false;
            Refresh();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
    
}
