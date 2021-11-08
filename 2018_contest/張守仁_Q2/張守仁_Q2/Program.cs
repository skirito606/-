using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 張守仁_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入範例檔案名稱:");
            string input = Console.ReadLine();
            StreamReader sr = new StreamReader(input);

            string r = "";
            string[] read;
            double[] max = new double[35];
            double[] min = new double[35];
            double[] close = new double[35];
            double[,] DM = new double[2, 34];
            double[] TR = new double[34];
            double[,] arg = new double[3, 25];
            double[,] DI = new double[2, 25];
            double[] DX = new double[25];
            double[] ADX = new double[16];

            for (int i = 0; i < 6; i++)
            {
                r = sr.ReadLine();
                read = r.Split(' ');
                if (i % 2 != 0)
                    for (int j = 0; j < 35; j++)
                        switch (i)
                        {
                            case 1:
                                max[j] = Convert.ToDouble(read[j]);
                                break;
                            case 3:
                                close[j] = Convert.ToDouble(read[j]);
                                break;
                            case 5:
                                min[j] = Convert.ToDouble(read[j]);
                                break;
                        }
            }
            //----------------DM+TR----------------
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 34; j++)
                {
                    if (i == 0)
                    {
                        DM[i, j] = (max[j + 1] * 10 - max[j] * 10) / 10;
                        if (DM[i, j] < 0)
                            DM[i, j] = 0;
                    }
                    else
                    {
                        DM[i, j] = (min[j] * 10 - min[j + 1] * 10) / 10;
                        if (DM[i, j] < 0)
                            DM[i, j] = 0;
                    }
                }
            }
            for (int j = 0; j < 34; j++)
            {
                double a, b, c;
                if (DM[0, j] > DM[1, j])
                    DM[1, j] = 0;
                else if (DM[0, j] < DM[1, j])
                    DM[0, j] = 0;
                else
                {
                    DM[0, j] = 0; DM[1, j] = 0;
                }
                a = Math.Abs((max[j + 1] * 10 - min[j + 1] * 10) / 10);
                b = Math.Abs((max[j + 1] * 10 - close[j] * 10) / 10);
                c = Math.Abs((min[j + 1] * 10 - close[j] * 10) / 10);
                if (a > b)
                {
                    if (a > c)
                        TR[j] = a;
                    else
                        TR[j] = c;
                }
                else
                {
                    if (b > c)
                        TR[j] = b;
                    else
                        TR[j] = c;
                }
            }
            //----------------arg----------------
            for (int i = 0; i < 25; i++)
            {
                double a = 0, b = 0, c = 0;
                for (int j = 0; j < 10; j++)
                {
                    a += DM[0, j + i] * 10;
                    b += DM[1, j + i] * 10;
                    c += TR[j + i] * 10;
                }
                arg[0, i] = a / 100;
                arg[1, i] = b / 100;
                arg[2, i] = c / 100;
            }
            //----------------DI+DX----------------
            for (int i = 0; i < 25; i++)
            {
                DI[0, i] = (arg[0, i] * 100 / (arg[2, i] * 100));
                DI[1, i] = (arg[1, i] * 100 / (arg[2, i] * 100));
                DX[i] = 100 * Math.Abs(DI[0, i] - DI[1, i]) / (DI[0, i] + DI[1, i]);
            }
            //----------------ADX----------------
            Console.Write("ADX: ");
            for (int i = 0; i < 16; i++)
            {
                double a = 0;
                for (int j = 0; j < 10; j++)
                {
                    a += DX[j + i];
                }
                ADX[i] = Math.Round(a / 10, 2);
                if (i != 0)
                    Console.Write(ADX[i].ToString("0.00") + " ");
            }
            Console.Write("\n預測: ");
            for (int i = 0; i < 15; i++)
            {
                if (ADX[i + 1] >= ADX[i])
                    Console.Write("1     ");
                else
                    Console.Write("0     ");
            }
            Console.ReadKey();
        }
    }
}
