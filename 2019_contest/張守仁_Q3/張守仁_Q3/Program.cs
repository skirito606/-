using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 張守仁_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入密文：(直接Enter則結束程式)");
            string M = Console.ReadLine();
            while(M!="")
            {
                string[] w = M.Split(' ');
                int[] word = new int[5];
                int[] temp = new int[5];
                int[] h = new int[] { 0xabcd, 0xcdef, 0x2266, 0xceed, 0xaccd };
                for (int i = 0; i < word.Length; i++)
                {
                    temp[i] = Convert.ToInt32(w[i], 16) - h[i];
                }
                for (int i = 0; i < word.Length; i++)
                {
                    word[i] = temp[4 - i] - (4 * h[0] + h[1] + h[2] + h[4] + 0x5a82) + 32;

                    h[4] = h[3];
                    h[3] = h[2];
                    h[2] = h[1];
                    h[1] = h[0];
                    h[0] = temp[4 - i];
                    Console.Write((char)word[i]);
                }
                Console.WriteLine();
                Console.WriteLine("請輸入密文：(直接Enter則結束程式)");
                M = Console.ReadLine();
            } 
        }
    }
}
/*
            string M;
            int[] word = new int[5];
            Console.WriteLine("請輸入密文：");
            M = Console.ReadLine();
            int h0=0xabcd, h1= 0xcdef, h2=0x2266, h3=0xceed, h4=0xaccd;
            int a=h0, b=h1, c=h2, d=h3, e=h4,f,k,temp;
            for (int i = 0; i < 5; i++)
            {
                word[i] = Convert.ToInt32(Convert.ToString(M[i],16),16);
                f = b + c; 
                k = 0x5a82;
                temp= 4 * a + f + e + k + word[i];
                e=d; 
                d=c; 
                c=b; 
                b=a; 
                a=temp;
            }
            h0=h0 + a; 
            h1=h1 + b; 
            h2=h2 + c; 
            h3=h3 + d; 
            h4=h4 + e;
            
            Console.WriteLine(Convert.ToString(h0, 16));
            Console.WriteLine(Convert.ToString(h1, 16));
            Console.WriteLine(Convert.ToString(h2, 16));
            Console.WriteLine(Convert.ToString(h3, 16));
            Console.WriteLine(Convert.ToString(h4, 16));
            */
