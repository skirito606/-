using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 張守仁_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] input = new string[3];
        private void 選取資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input_text.Text = "";
            output_text.Text = "";

            string filename;
            StreamReader read;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "記事本(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                read = new StreamReader(filename);

                for (int i = 0; i < 3; i++)
                {
                    input[i] = read.ReadLine();
                    input_text.Text += input[i] + "\r\n";
                    input[i] = input[i].Remove(0, 6);
                }
            }
        }

        

        private void 求F統計值及自由度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[][] data = new double[3][];
            double[] ut = new double[3];
            double UT=0, SSb=0, SSw=0, MSb, MSw, F;
            int N = 0, dfb, dfw;

            
            for (int i = 0; i < 3; i++)
            {
                string[] s;
                s = input[i].Split('\t');
                data[i] = new double[s.Length];
                for (int j = 0; j < s.Length; j++)
                    data[i][j] = Convert.ToDouble(s[j]);
            }
            //-----------------------------------------
            N = data[0].Length + data[1].Length + data[2].Length;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    ut[i] += data[i][j] / data[i].Length;
                    UT += data[i][j] / N;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                SSb += data[i].Length * (ut[i] - UT) * (ut[i] - UT);
                for (int j = 0; j < data[i].Length; j++)
                {
                    SSw += (data[i][j] - ut[i]) * (data[i][j] - ut[i]);
                }
            }
            dfb = 2; dfw = N - 3;
            MSb = SSb / dfb; MSw = SSw / dfw;
            F =MSb / MSw;
            F = (int)(F * 10000);
            if (F % 10 < 5)
                F = (F - F % 10) / 10000;
            else
                F = (F - F % 10+10) / 10000;
            //-------------------------------------
            output_text.Text = "F統計值計算:\r\n" + "F=" + F + "\r\n" + "自由度df:" + dfb + "," + dfw;
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
