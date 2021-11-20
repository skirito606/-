using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code演算法_Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, string> roman = new Dictionary<int, string>();
            roman.Add(1, "I");
            roman.Add(4, "IV");
            roman.Add(5, "V");
            roman.Add(9, "IX");
            roman.Add(10, "X");
            roman.Add(40, "XL");
            roman.Add(50, "L");
            roman.Add(90, "XC");
            roman.Add(100, "C");
            roman.Add(400, "CD");
            roman.Add(500, "D");
            roman.Add(900, "CM");
            roman.Add(1000, "M");

            int[] n = new int[4];
            n[0] = num - num % 1000;
            n[1] = num % 1000 - num % 100;
            n[2] = num % 100 - num % 10;
            n[3] = num % 10;


            string output = "";
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] / 4 == Math.Pow(10, 3 - i) && n[i] % 4 == 0 && n[i] != 0)
                    output += roman[n[i]];
                else if (n[i] / 5 == Math.Pow(10, 3 - i) && n[i] % 5 == 0 &&  n[i] != 0)
                    output += roman[n[i]];
                else if (n[i] % 9 == 0 && n[i] != 0)
                    output += roman[n[i]];
                else
                {
                    int a = 0;
                    switch (i)
                    {
                        case 0:
                            a = 1000;
                            break;
                        case 1:
                            a = 100;
                            break;
                        case 2:
                            a = 10;
                            break;
                        case 3:
                            a = 1;
                            break;
                    }
                    if (n[i] / a < 5)
                        for (int j = 0; j < n[i] / a; j++)
                            output += roman[a];
                    else
                    {
                        output += roman[5 * a];
                        for (int j = 0; j < n[i] / a - 5 ; j++)
                            output += roman[a];
                    }
                }
            }


            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
