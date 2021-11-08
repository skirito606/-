using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 張守仁_Q5
{
    class Program
    {
        struct value
        {
            public int max;
            public int sum;
            public int[] range;
            public int[] array;
        }

        static void Main(string[] args)
        {
            value v;
            string r;

            Console.Write("輸入陣列大小:");
            r = Console.ReadLine();
            while (Convert.ToInt16(r) >= 100 || Convert.ToInt16(r) <= 0)
            {
                Console.WriteLine("不符規則,請再次輸入");
                Console.Write("輸入陣列大小:");
                r = Console.ReadLine();
            }
            v.array = new int[Convert.ToInt16(r)];

            r = Console.ReadLine();
            for (int i = 0; i < v.array.Length; i++)
                v.array[i] = Convert.ToInt16(r.Split(' ')[i]);

            v.range = new int[2];
            v.max = v.array[0];

            for (int i = 1; i < v.array.Length + 1; i++)//加多少次
            {
                for (int j = 0; j < v.array.Length - (i - 1); j++)//起點初始值迴圈
                {
                    v.sum = 0;
                    for (int k = 0; k < v.array.Length - (v.array.Length - i); k++)//起點到終點迴圈
                        v.sum += v.array[j + k];
                    if (v.sum > v.max)
                    {
                        v.max = v.sum;
                        v.range[0] = j;
                        v.range[1] = j + i - 1;
                    }
                }
            }
            Console.WriteLine(v.max + "\n" + v.range[0] + " " + v.range[1]);
            Console.ReadKey();
        }
    }
}
