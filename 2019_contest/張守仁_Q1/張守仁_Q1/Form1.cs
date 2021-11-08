using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 張守仁_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int money=0;
        private void deposit_Click(object sender, EventArgs e)
        {

            if (fifty.Checked == true)
                money += 50;
            else if (ten.Checked == true)
                money += 10;
            else if (five.Checked == true)
                money += 5;
            balance.Text = money.ToString() + ".0";
        }

        private void refund_Click(object sender, EventArgs e)
        {
            if (balance.Text != "0.0")
            {
                if (image.Text != "")
                {
                    image.Text += " 退還" + money + "元";
                    money = 0;
                    balance.Text = money.ToString() + ".0";
                }
                else
                {
                    image.Text = "退還" + money + "元";
                    money = 0;
                    balance.Text = money.ToString() + ".0";
                }
            }
            else
                image.Text = "";
        }

        private void cola_Click(object sender, EventArgs e)
        {
            if(money>=35)
            {
                money -= 35;
                balance.Text = money.ToString() + ".0";
                if (image.Text != "")
                    image.Text += ",送出Cola";
                else
                    image.Text += "送出Cola";
            }
        }

        private void Diet_Cola_Click(object sender, EventArgs e)
        {
            if (money >= 30)
            {
                money -= 30;
                balance.Text = money.ToString() + ".0";
                if (image.Text != "")
                    image.Text += ",送出Diet Cola";
                else
                    image.Text += "送出Diet Cola";
            }
        }

        private void Pepsi_Click(object sender, EventArgs e)
        {
            if (money >= 30)
            {
                money -= 30;
                balance.Text = money.ToString() + ".0";
                if (image.Text != "")
                    image.Text += ",送出Pepsi";
                else
                    image.Text += "送出Pepsi";
            }
        }

        private void Diet_Pepsi_Click(object sender, EventArgs e)
        {
            if (money >= 25)
            {
                money -= 25;
                balance.Text = money.ToString() + ".0";
                if (image.Text != "")
                    image.Text += ",送出Diet Pepsi";
                else
                    image.Text += "送出Diet Pepsi";
            }
        }
    }
}
