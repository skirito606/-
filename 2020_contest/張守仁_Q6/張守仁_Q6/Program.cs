using System;
using System.IO;

namespace 張守仁_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string[] d;
            string[,] data = new string[9, 16];
            int faults;
            //讀取資料
            Console.Write("Enter org filename:");
            StreamReader sr = new StreamReader(Console.ReadLine());   
            for (int y = 0; y < 9; y++)
            {
                s = sr.ReadLine();
                d = s.Split(' ');
                string f = "";
                f = Str(f, d);
                for (int x = 0; x < f.Length; x++)
                {
                    data[y, x] = f[x].ToString();
                }
            }
            
            //讀取比較資料
            Console.Write("Enter pattern filename:");
            sr = new StreamReader(Console.ReadLine());
            s = sr.ReadLine();
            d = s.Split(' ');
            string[,] compare_data = new string[Convert.ToInt32(d[1], 16), Convert.ToInt32(d[0], 16)];
            for (int y = 0; y < compare_data.GetLength(0); y++)
            {
                s = sr.ReadLine();
                d = s.Split(' ');
                string f = "";
                f = Str(f, d);
                for (int x = 0; x < compare_data.GetLength(1); x++)
                {
                    compare_data[y, x] = f[x].ToString();
                }
            }
            //讀取容忍錯誤量
            Console.Write("Enter Number of faults:");
            faults = Convert.ToInt32(Console.ReadLine());



            int y1 = -1, x1 = -1, y2 = 0, x2 = 0, F = 0, i = 0;
            bool compare = false;
            for (int y = 0; y < data.GetLength(0); y++)
            {
                if (compare)
                    break;
                x2 = 0;
                for (int x = i; x < data.GetLength(1); x++)
                {
                    if (data[y, x] == compare_data[y2, x2])
                    {
                        if (x2 == compare_data.GetLength(1) - 1)
                        {
                            if (y2 == compare_data.GetLength(0) - 1)
                            {
                                x1 = x - x2;
                                y1 = y - y2;
                                x2 = x + 1;
                                y2 = y + 1;
                                compare = true;
                                break;
                            }
                            else
                            {
                                i = x - x2;
                                y2++;
                                break;
                            }
                        }
                        else
                            x2++;
                    }
                    else
                    {
                        F++;
                        if (F > faults)
                        {
                            x2 = 0;
                            y2 = 0;
                            i = 0;
                            F = 0;
                            if (data.GetLength(1) - 1 - x < x2)
                                break;
                        }
                        else
                        {
                            if (x2 == compare_data.GetLength(1) - 1)
                            {
                                if (y2 == compare_data.GetLength(0) - 1)
                                {
                                    x1 = x - x2;
                                    y1 = y - y2;
                                    x2 = x + 1;
                                    y2 = y + 1;
                                    compare = true;
                                    break;
                                }
                                else
                                {
                                    i = x - x2;
                                    y2++;
                                    break;
                                }
                            }
                            else if (data.GetLength(1) - 1 - x < compare_data.GetLength(1) - 1 - x2)
                            {
                                F = 0;
                                i = 0;
                                break; 
                            }
                               
                            else
                                x2++;
                        }

                    }
                }

            }

            if (x1 == -1 && y1 == -1)
                Console.WriteLine("No match");
            else
                Console.WriteLine("x1:{0}, y1:{1}, x2:{2}, y3:{3}", x1, y1, x2, y2);
            Console.ReadKey();

        }
        static string Str(string f, string[] d)
        {  
            for (int i = d.Length - 1; i >= 0; i--)
            {
                f =  Convert.ToString(Convert.ToInt32(d[i], 16), 2).PadLeft(8, '0') + f;
            }
            return f;
        }
    }
}



/*
for (int y = 0; y < data.GetLength(0); y++)
{
    for (int x = 0; x < data.GetLength(1); x++)
    {
        if (x == data.GetLength(1) - 1)
            Console.WriteLine(data[y, x]);
        else
            Console.Write(data[y, x]);
    }
}
for (int y = 0; y < compare_data.GetLength(0); y++)
{
    for (int x = 0; x < compare_data.GetLength(1); x++)
    {
        if (x == compare_data.GetLength(1) - 1)
            Console.WriteLine(compare_data[y, x]);
        else
            Console.Write(compare_data[y, x]);
    }
}

*/

/*
                switch (f.Length % 8)
                {
                    case 1:
                        f = "0000000" + f;
                        break;
                    case 2:
                        f = "000000" + f;
                        break;
                    case 3:
                        f = "00000" + f;
                        break;
                    case 4:
                        f = "0000" + f;
                        break;
                    case 5:
                        f = "000" + f;
                        break;
                    case 6:
                        f = "00" + f;
                        break;
                    case 7:
                        f = "0" + f;
                        break;
                }*/