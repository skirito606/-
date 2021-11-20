using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ_decode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入QQ號:");
            string s = Console.ReadLine();
            int[] input = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                input[i] = Convert.ToInt32(s[i].ToString());

            
            Console.ReadKey();
        }
    }
}
