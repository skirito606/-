using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 張守仁_Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入大地遊戲關卡文字檔檔名：");
            StreamReader read = new StreamReader(Console.ReadLine());
            int point = Convert.ToInt16(read.ReadLine());
            if (point > 1 && point < 30)
            {
                double[,] data = new double[point, point];
                string f;
                for (int y = 0; y < point; y++)
                {
                    f = read.ReadLine();
                    for (int x = 0; x < point; x++)
                    {
                        data[y, x] = Convert.ToDouble(f.Split(' ')[x]);
                    }
                }
                string[] SE = new string[2];
                f = read.ReadLine();
                SE = f.Split(' ');


                Console.Write("大地遊戲關卡文字檔內容為：\n" + point + "\n");
                for (int y = 0; y < point; y++)
                {
                    for (int x = 0; x < point; x++)
                    {
                        if (x != point - 1)
                        {
                            if (data[y, x] == 0)
                                Console.Write("0." + data[y, x] + " ");
                            else
                                Console.Write(data[y, x] + " ");
                        }
                        else
                        {
                            if (data[y, x] == 0)
                                Console.WriteLine("0." + data[y, x]);
                            else
                                Console.WriteLine(data[y, x]);
                        }
                    }
                }
                Console.WriteLine(SE[0] + " " + SE[1]);
                //尋找最短路徑
                for (int y = 0; y < point; y++)
                    for (int x = 0; x < point; x++)
                    {
                        if(data[y,x]==0)
                            data[y, x] =999;
                    }
                Double[] way = new double[point];         //記錄起點到各點最短距離
                int[] parent = new int[point];      //記錄各點的根
                bool[] visit = new bool[point];     //紀錄是否被拜訪

                for (int i = 0; i < point; i++)
                {
                    visit[i] = false;               //設定各點尚未被拜訪
                    way[i] = 999;                   //設定起點到各點的距離為一大數
                }
                way[Convert.ToInt16(SE[0]) - 1] = 0;    //將起點到起點的距離設為0
                parent[Convert.ToInt16(SE[0]) - 1] = Convert.ToInt16(SE[0]) - 1;         //將起點的根為自己

                for (int k = 0; k < point; k++)
                {
                    int a = -1;
                    double min = 999;

                    for (int i = 0; i < point; i++)
                        if (!visit[i] && way[i] < min)
                        {
                            a = i;  // 記錄這一條邊
                            min = way[i];
                        }

                    if (a == -1)
                        break;     // 起點有連通的最短路徑都已找完

                    visit[a] = true;

                    // 以邊ab進行relaxation
                    for (int b = 0; b < point; b++)
                        if (!visit[b] && way[a] + data[a, b] < way[b])
                        {
                            way[b] = Convert.ToDouble((Decimal)way[a] + (Decimal)data[a, b]);
                            parent[b] = a;
                        }
                }
                Console.Write("最快的闖關路線 [{0} -> {1}]: ",SE[0],SE[1]);
                int []SEway = new int[point];
                SEway[0] = Convert.ToInt16(SE[1]);
                for(int i=1;i<point;i++)
                {
                    SEway[i] = parent[SEway[i-1]-1]+1;
                    if(SEway[i]== SEway[i-1])
                    {
                        SEway[i] = 0;
                        break;
                    }
                }
                for(int i=point-1;i>-1;i--)
                {
                    if (i==0)
                        Console.Write(SEway[i]);
                    else if (SEway[i] != 0)
                        Console.Write(SEway[i] + "->");
                }
                Console.WriteLine("(路途嚴峻程度 "+way[Convert.ToInt16(SE[1])-1]+")");
            }
            else
                Console.WriteLine("關卡數不符合規則");
            Console.ReadKey();

        }
    }
}
