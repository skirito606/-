using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 張守仁_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Graphics draw;
        Pen p;
        Random rd = new Random();


        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Pen(Color.Black, 2);
            bmp = new Bitmap(330, 400);
            draw = Graphics.FromImage(bmp);
            draw.DrawRectangle(p, 0, 0, 200, 200);
            graph_CR.Image = bmp;
        }

        public int[,] point;
        //int x1, x2, x3, x4, y1, y2, y3, y4;
        private void RB_Click(object sender, EventArgs e)
        {
            draw.Clear(Color.White);
            int time = rd.Next(2, 3);
            int[,] rectangle = new int[time, 4];
            switch (time)
            {
                case 2:
                    do
                    {
                        rectangle = Rectangle(time);

                    } while (rectangle[0, 0] > (rectangle[1, 0] + rectangle[1, 2]) || rectangle[1, 0] > (rectangle[0, 0] + rectangle[0, 2])
                          || rectangle[0, 1] > (rectangle[1, 1] + rectangle[1, 3]) || rectangle[1, 1] > (rectangle[0, 1] + rectangle[0, 3]));
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            for (int i = 0; i < time; i++)
            {
                //p.DashPattern = new float[] { rd.Next(1, 5), rd.Next(1, 5), rd.Next(1, 5), rd.Next(1, 5) };
                draw.DrawRectangle(p, rectangle[i, 0], rectangle[i, 1], rectangle[i, 2], rectangle[i, 3]);
                graph_RB.Image = bmp;
            }
        }
        private void CR_Click(object sender, EventArgs e)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int[,] Rectangle(int t)
        {
            int[,] r = new int[t, 4];
            point = new int[t, 4];
            for (int y = 0; y < t; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (x < 2)
                        r[y, x] = rd.Next(20, 81);
                    else
                        r[y, x] = rd.Next(40, 201);


                    //if (x == 3)
                    //  p[y,1]-=p[y,x];
                }
            }
            return r;
        }
    }
}

