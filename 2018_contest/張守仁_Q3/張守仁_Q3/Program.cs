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
            Console.Write("請輸入密碼:");
            string a=Console.ReadLine();
            Console.WriteLine("\n密碼長度:" + a.Length);
            char[] word = new char[a.Length];
            int[] marks = new int[] {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '_', '='};
            int num = 0;
            int upper = 0;
            int lower = 0;
            int mark = 0;
            int compare =0;
            for(int i=0;i<a.Length;i++)
            {
                word[i] = a[i];
                if (word[i] >= 48 && word[i] <= 57)
                    num++;
                else if (word[i] >= 65 && word[i] <= 90)
                    upper++;
                else if (word[i] >= 97 && word[i] <= 122)
                    lower++;
                else
                    for (int j = 0; j < 14; j++)
                        if (word[i] == marks[j])
                            mark++;
            }
            
            if (upper != 0)
                compare++;
            Console.WriteLine("大寫英文字母長度:" + upper);
            if (lower != 0)
                compare++;
            Console.WriteLine("小寫英文字母長度:" + lower);
            if (num != 0)
                compare++;
            Console.WriteLine("數字長度:" + num);
            if (mark != 0)
                compare++;
            Console.WriteLine("符號長度:" + mark);
            if (compare >= 3 && a.Length >= 8 && a.Length <= 128)
                Console.WriteLine("符合密碼規則");
            else
                Console.WriteLine("不符密碼規則");
            Console.ReadKey();
        }
    }
}
