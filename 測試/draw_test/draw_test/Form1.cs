using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Graphics draw;
        Pen pen;
        SolidBrush b;

        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 2);
            b = new SolidBrush(Color.Black);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            draw = Graphics.FromImage(bmp);


            draw.TranslateTransform(50, 25);//變更畫布原點座標(new x,new y)
            draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//圖形滑順設定
            /*int dia = 20;//圓直徑
            draw.FillEllipse(b, 0-dia/2, 0-dia/2, 20, 20);*/



            int x_range = 50, y_range = 50;
            int x_start = 0, y_start = 0;
            int x_difference = x_range - x_start,
                y_difference = y_range - y_start;
            int x, y;
            for (int i = 1; i <= 15; i++)
            {
                x = x_range * i - x_difference;
                y = y_range * i - y_difference;
                draw.DrawLine(pen, x, y_start, x, y_start + 400);
                draw.DrawString((i - 1).ToString("#0"), Font, Brushes.Black, x - 18, y_start + 400 + 9);

                if (i <= 9)
                {
                    draw.DrawLine(pen, x_start, y, x_start + 700, y);
                    draw.DrawString((9 - i).ToString("#0"), Font, Brushes.Black, x_start - 18, y + 9);
                }
            }
            for (int i = 1; i <= 14; i++)
            {
                x = x_range * i - x_difference;
                y = y_range * i - y_difference;
                
                for (int j = 0; j < 8; j++)
                {
                    draw.FillEllipse(b, (float)(x + 2.5), (float)(y_start + 2.5 +j*50), 45, 45);
                    //draw.FillEllipse(b, (float)(x_start + 2.5), (float)(y + 2.5), 45, 45);
                }
            }

            pictureBox1.Image = bmp;
        }
    }
}
