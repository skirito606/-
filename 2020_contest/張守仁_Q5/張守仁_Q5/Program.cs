using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace 張守仁_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string conpare = @"^[-+*/0-9]+$";
            Console.WriteLine("請輸入運算式： (輸入 @ 結束)");
            a = Console.ReadLine();
            ulong A = 0;
            while (a != "@")
            {               
                string[] data = new string[20];
                string[] op = new string[20];
                if (a.Length <= 1500 && Regex.IsMatch(a, conpare))
                {
                    a += " ";
                    int d = 0, z;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (int.TryParse(a[i].ToString(), out z))
                        {
                            data[d] += a[i];                               
                        }
                        if (d != 0 && !Regex.IsMatch(a[i + 1].ToString(), @"[0-9]+$"))
                        {
                            if (op[d - 1] == "*")
                            {
                                A = Convert.ToUInt64(data[d - 1]) * Convert.ToUInt64(data[d]);
                                data[d] = null;
                                d--;
                                data[d] = A.ToString();
                                op[d] = null;
                            }
                            else if (op[d - 1] == "/")
                            {
                                A = Convert.ToUInt64(data[d - 1]) / Convert.ToUInt64(data[d]);
                                data[d] = null;
                                d--;
                                data[d] = A.ToString();
                                op[d] = null;
                            }
                        }
                        if (d != 0 && !Regex.IsMatch(a[i + 1].ToString(), @"^[*/0-9]+$"))
                        {
                            if (op[d - 1] == "+" )
                            {
                                A = Convert.ToUInt64(data[d - 1]) + Convert.ToUInt64(data[d]);
                                data[d] = null;
                                d--;
                                data[d] = A.ToString();
                                op[d] = null;
                            }
                            else if (op[d - 1] == "-" )
                            {
                                A = Convert.ToUInt64(data[d - 1]) - Convert.ToUInt64(data[d]);
                                data[d] = null;
                                d--;
                                data[d] = A.ToString();
                                op[d] = null;
                            }
                        }
                        else if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/')
                        {
                            op[d] = a[i].ToString();
                            d++;
                        }                                        
                    }

                    Console.WriteLine("\n你輸入的數學運算式為：\n" + a + "\n運算結果 = " + A%10000 + "\n");
                    Console.WriteLine("請輸入運算式： (輸入 @ 結束)");
                    a = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n資料錯誤，請重新輸入\n");
                    Console.WriteLine("請輸入運算式： (輸入 @ 結束)");
                    a = Console.ReadLine();
                }

            }

        }
    }
}
