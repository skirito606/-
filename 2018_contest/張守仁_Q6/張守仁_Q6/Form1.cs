using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 張守仁_Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        int time;
        string t = "";
        private void rd1_Click(object sender, EventArgs e)
        {
            t = "";
            huffman_text1.Text = "";
            string[,] ct = new string[2, 5] { { "10", "01", "11", "001", "000" }, { "A", "B", "C", "D", "E" } };
            int value = 0;
            time = 0;
            while (time < rd.Next(26, 51))
            {
                value = rd.Next(5);
                if (value <= 2)
                    time += 2;
                else
                    time += 3;
                huffman_text1.Text += ct[0, value];
                t += ct[1, value];
            }
            confirm1.Text = "";
            decode_text1.Text = "";
        }

        private void rd2_Click(object sender, EventArgs e)
        {
            time = rd.Next(26, 51);
            huffman_text2.Text = "";
            for (int i = 0; i < time; i++)
            {
                huffman_text2.Text += rd.Next(0, 2).ToString();
            }
            confirm2.Text = "";
            decode_text2.Text = "";
        }


        private void decoding_Click(object sender, EventArgs e)
        {
            int addr = 0;
            string text = "";
            while (addr + 2 <= huffman_text2.Text.Length)
            {
                if (huffman_text2.Text[addr] == '0')
                {
                    if (huffman_text2.Text[addr + 1] == '0')
                    {
                        if (addr + 2 != huffman_text2.Text.Length)
                        {
                            if (huffman_text2.Text[addr + 2] == '0')//E
                            {
                                addr += 3;
                                text += "E";
                            }
                            else if (huffman_text2.Text[addr + 2] == '1')//D
                            {
                                addr += 3;
                                text += "D";
                            }
                        }
                        else
                        {
                            confirm2.Text = "不合理";
                            break;
                        }
                    }
                    else if (huffman_text2.Text[addr + 1] == '1')//B
                    {
                        addr += 2;
                        text += "B";
                    }
                }
                else if (huffman_text2.Text[addr] == '1')
                {
                    if (huffman_text2.Text[addr + 1] == '0')//A
                    {
                        addr += 2;
                        text += "A";
                    }
                    else if (huffman_text2.Text[addr + 1] == '1')//C
                    {
                        addr += 2;
                        text += "C";
                    }
                }
            }

            if (addr == huffman_text2.Text.Length)
                decode_text2.Text = text;
            else
                confirm2.Text = "不合理";

            decode_text1.Text = t;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
