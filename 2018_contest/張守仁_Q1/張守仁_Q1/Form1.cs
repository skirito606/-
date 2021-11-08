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

        Bitmap tl = new Bitmap(440, 330);
        Graphics draw;
        Pen colorpen = new Pen(Color.Black, 1);
        Font f = new Font("新細明體", 12, FontStyle.Bold);
        int time = 0;
        bool on = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
            pb.Image = tl;

        }

        private void ON_Click(object sender, EventArgs e)
        {
            if (!on)
            {
                draw.FillEllipse(Brushes.Red, 30, 15, 40, 40);
                draw.DrawEllipse(colorpen, 30, 15, 40, 40);
                draw.FillEllipse(Brushes.LimeGreen, 342, 265, 40, 40);
                draw.DrawEllipse(colorpen, 342, 265, 40, 40);
                pb.Image = tl;
                time = 1;
                on = true;
            }
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            draw.Clear(SystemColors.Control);
            start();
            pb.Image = tl;
            on = false;
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (on)
            {
                time++;
                draw.Clear(SystemColors.Control);
                start();
                switch (time)
                {
                    case 0:
                        break;
                    case 1:
                        draw.FillEllipse(Brushes.Red, 30, 15, 40, 40);
                        draw.DrawEllipse(colorpen, 30, 15, 40, 40);
                        draw.FillEllipse(Brushes.LimeGreen, 342, 265, 40, 40);
                        draw.DrawEllipse(colorpen, 342, 265, 40, 40);
                        break;
                    case 2:
                        draw.FillEllipse(Brushes.Red, 30, 15, 40, 40);
                        draw.DrawEllipse(colorpen, 30, 15, 40, 40);
                        draw.FillEllipse(Brushes.Yellow, 262, 265, 40, 40);
                        draw.DrawEllipse(colorpen, 262, 265, 40, 40);
                        break;
                    case 3:
                        draw.FillEllipse(Brushes.Red, 30, 15, 40, 40);
                        draw.DrawEllipse(colorpen, 30, 15, 40, 40);
                        draw.FillEllipse(Brushes.Red, 182, 265, 40, 40);
                        draw.DrawEllipse(colorpen, 182, 265, 40, 40);
                        break;
                    case 4:
                        draw.FillEllipse(Brushes.LimeGreen, 30, 135, 40, 40);
                        draw.DrawEllipse(colorpen, 30, 135, 40, 40);
                        draw.FillEllipse(Brushes.Red, 182, 265, 40, 40);
                        draw.DrawEllipse(colorpen, 182, 265, 40, 40);
                        break;
                    case 5:
                        draw.FillEllipse(Brushes.Yellow, 30, 75, 40, 40);
                        draw.DrawEllipse(colorpen, 30, 75, 40, 40);
                        draw.FillEllipse(Brushes.Red, 182, 265, 40, 40);
                        draw.DrawEllipse(colorpen, 182, 265, 40, 40);
                        break;
                    case 6:
                        draw.FillEllipse(Brushes.Red, 30, 15, 40, 40);
                        draw.DrawEllipse(colorpen, 30, 15, 40, 40);
                        draw.FillEllipse(Brushes.Red, 182, 265, 40, 40);
                        draw.DrawEllipse(colorpen, 182, 265, 40, 40);
                        time = 0;
                        break;
                }
                pb.Image = tl;
            }
        }

        void start()
        {
            draw = Graphics.FromImage(tl);

            draw.DrawLine(colorpen, 80, 10, 80, 305);
            draw.DrawLine(colorpen, 130, 10, 130, 305);
            draw.DrawLine(colorpen, 25, 210, 430, 210);
            draw.DrawLine(colorpen, 25, 260, 430, 260);

            draw.DrawString("R1", f, Brushes.Black, 0, 30);
            draw.DrawString("A1", f, Brushes.Black, 0, 90);
            draw.DrawString("G1", f, Brushes.Black, 0, 150);
            draw.DrawString("R2", f, Brushes.Black, 190, 305);
            draw.DrawString("A2", f, Brushes.Black, 270, 305);
            draw.DrawString("G2", f, Brushes.Black, 350, 305);
        }

    }
}
