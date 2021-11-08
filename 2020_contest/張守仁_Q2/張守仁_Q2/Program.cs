using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace 張守仁_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始繪製圖框!");
            StreamReader sr = new StreamReader("Labeldata.txt");
            string[][] data = new string[5][];
            Pen p = new Pen(Color.Red, 2);

            for (int y = 0; y < 5; y++)
            {
                string s = sr.ReadLine();
                string[] f = s.Split(' ');
                data[y] = new string[Convert.ToInt16(f[1]) * 4 + 2];
                for (int x = 0; x < f.Length; x++)
                {
                    if (x == 0)
                        data[y][x] = "./" + f[x];
                    else
                        data[y][x] = f[x];
                }
            }
            for (int y = 0; y < 5; y++)
            {
                int x1, y1, w, h;
                Console.WriteLine("在 {0} 圖檔中加框，以相同檔名存入 imageOUT 中", data[y][0]);
                Bitmap bmp = new Bitmap(data[y][0]);
                Graphics draw = Graphics.FromImage(bmp);
                for (int i = 0; i < Convert.ToInt16(data[y][1]); i++)
                {
                    x1 = Convert.ToInt16(data[y][2 + 4 * i]);
                    y1 = Convert.ToInt16(data[y][3 + 4 * i]);
                    w = Convert.ToInt16(data[y][4 + 4 * i]) - Convert.ToInt16(data[y][2 + 4 * i]);
                    h = Convert.ToInt16(data[y][5 + 4 * i]) - Convert.ToInt16(data[y][3 + 4 * i]);
                    draw.DrawRectangle(p, x1, y1, w, h);
                }
                bmp.Save("./imageOUT/" + data[y][0]);
            }
            Console.WriteLine("繪製圖框結束!");
            Console.ReadKey();
        }
    }
}
