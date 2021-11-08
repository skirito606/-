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

        private void bt_t_Click(object sender, EventArgs e)
        {
            string[] control = new string[] { "零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖" };
            threeA.Text = "三位分隔數：";
            bigA.Text = "輸出大寫：";
            long[] data = new long[number.Text.Length];
            long num;
            if (number.Text.Length <= 13 && number.Text.Length >= 1 && !number.Text.Contains("-") && long.TryParse(number.Text, out num))
            {

                for (int i = data.Length - 1; i >= 0; i--)
                {
                    data[i] = num / (long)Math.Pow(10, i);
                    num = num % (long)Math.Pow(10, i);
                }
                for (int i = data.Length - 1; i >= 0; i--)
                {
                    if (i % 3 == 0 && i != 0)
                        threeA.Text += data[i].ToString() + ",";
                    else
                        threeA.Text += data[i].ToString();
                }


                for (int i = data.Length - 1; i >= 0; i--)
                {
                    switch (i % 4)
                    {
                        case 0:
                            if (i == 12 && data[i] != 0)
                                bigA.Text += control[data[i]] + "兆";

                            if (i == 8 && data[i] != 0)
                                bigA.Text += control[data[i]] + "億";
                            else if (i == 8 && (data[i] != 0 || data[i + 1] != 0 || data[i + 2] != 0 || data[i + 3] != 0))
                                bigA.Text += "億";

                            if (i == 4 && data[i] != 0)
                                bigA.Text += control[data[i]] + "萬";
                            else if (i == 4 && (data[i] != 0 || data[i + 1] != 0 || data[i + 2] != 0 || data[i + 3] != 0))
                                bigA.Text += "萬";
                            if (i == 0 && (data[i] != 0))
                                bigA.Text += control[data[i]];
                            break;
                        case 1:
                            if (data[i] != 0)
                                bigA.Text += control[data[i]] + "拾";
                            else if (data[i + 1] != 0 && data[i - 1] != 0)
                                bigA.Text += control[data[i]];
                            break;
                        case 2:
                            if (data[i] != 0)
                                bigA.Text += control[data[i]] + "佰";
                            else if (data[i + 1] != 0 && data[i -1 ] != 0)
                                bigA.Text += control[data[i]];
                            /*else
                                bigA.Text += control[data[i]];*/
                            break;
                        case 3:
                            if (data[i] != 0)
                                bigA.Text += control[data[i]] + "仟";
                            else
                                bigA.Text += control[data[i]];
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("超過範圍，請重新輸入", "提示", MessageBoxButtons.OK);
                number.Text = "";
                threeA.Text = "三位分隔數：";
                bigA.Text = "輸出大寫：";
            }
        }

        private void bt_cl_Click(object sender, EventArgs e)
        {
            number.Text = "";
            threeA.Text = "三位分隔數：";
            bigA.Text = "輸出大寫：";
        }

    }
}
