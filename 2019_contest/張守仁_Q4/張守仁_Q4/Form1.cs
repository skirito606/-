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
        Random r = new Random();
        struct Location
        {
            public int[,] point;
        }
        Location location;

        private void Form1_Load(object sender, EventArgs e)
        {
            location.point = new int[11, 11];
            p = new Pen(Color.Black, 2);
            bmp = new Bitmap(450, 350);
            draw = Graphics.FromImage(bmp);
            write_line();
            path.Image = bmp;
        }

        private void Initalization_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
            draw.Clear(Color.White);
            write_line();
            location.point = new int[11, 11];
            for (int i = 0; i < 32; i++)
            {
                int x = r.Next(0, 11);
                int y = r.Next(0, 11);
                if (location.point[x, y] == 0)
                    location.point[x, y] = -1;
                else
                    i--;
            }
            byte flag = 0;
            while (flag != 2)
            {
                int x = r.Next(0, 11);
                int y = r.Next(0, 11);
                if (location.point[x, y] == 0 && flag == 0)
                {
                    location.point[x, y] = 1;
                    flag++;
                }
                if (location.point[x, y] == 0 && flag == 1)
                {
                    location.point[x, y] = 2;
                    flag++;
                }
            }
            write_point();
            path.Image = bmp;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void write_line()
        {
            for (int i = 1; i < 12; i++)
            {
                draw.DrawLine(p, 25, i * 30 - 5, 425, i * 30 - 5);//橫線
                draw.DrawLine(p, i * 40 - 15, 25, i * 40 - 15, 325);//直線
            }
        }

        void write_point()
        {
            for (int x = 10; x >= 0; x--)
            {
                for (int y = 10; y >= 0; y--)
                {
                    if (location.point[x, y] == -1)
                        draw.FillEllipse(Brushes.Black, (x + 1) * 40 - 25, (y + 1) * 30 - 15, 20, 20);
                    if (location.point[x, y] == 1)
                    {
                        p.Color = Color.Blue;
                        draw.FillEllipse(Brushes.White, (x + 1) * 40 - 25, (y + 1) * 30 - 15, 20, 20);
                        draw.DrawEllipse(p, (x + 1) * 40 - 25, (y + 1) * 30 - 15, 20, 20);
                    }
                    if (location.point[x, y] == 2)
                    {
                        p.Color = Color.Red;
                        draw.FillRectangle(Brushes.White, (x + 1) * 40 - 25, (y + 1) * 30 - 15, 20, 20);
                        draw.DrawRectangle(p, (x + 1) * 40 - 25, (y + 1) * 30 - 15, 20, 20);
                    }
                }
            }
        }
    }
}
