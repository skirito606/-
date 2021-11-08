using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 張守仁_Q6
{
    class Program
    {

        static void Main(string[] args)
        {

            string r;
            string[] read, in_box_name, box_name, out_box_name;
            int[] in_box_value, box_value, out_box_value;
            string[,] transform2_1, transform1_1;
            int times = 0;
            r = "";
            //-----------------test------------------------
            /*
            in_box_name = new string []{"a","b","c","d"};
            box_name = new string[] { "e", "f", "g", "h" };
            out_box_name = new string[] {"i"};
            in_box_value = new int[4];
            box_value = new int[4];
            out_box_value = new int[1];
            transform1_1 =new string[,]{{"t1","a","e"}};
            transform2_1 = new string[,] { { "t2", "b", "c","f" },
                                           { "t3", "e", "f","g" },
                                           { "t4", "d", "f","h" },
                                           { "t5", "g", "h","i" }};
            */
            Console.WriteLine("鍵入「輸入小圓盤」的數目及其名稱:");
            r = Console.ReadLine();
            read = r.Split(' ');
            in_box_name = new string[Convert.ToByte(read[0])];
            in_box_value = new int[Convert.ToByte(read[0])];
            for (int i = 0; i < in_box_name.Length; i++)
            {
                in_box_name[i] = read[i + 1].ToString();
            }

            Console.WriteLine("鍵入「內部小圓盤」的數目及其名稱:");
            r = Console.ReadLine();
            read = r.Split(' ');
            box_name = new string[Convert.ToByte(read[0])];
            box_value = new int[Convert.ToByte(read[0])];
            for (int i = 0; i < box_name.Length; i++)
            {
                box_name[i] = read[i + 1].ToString();
            }

            Console.WriteLine("鍵入「輸出小圓盤」的數目及其名稱:");
            r = Console.ReadLine();
            read = r.Split(' ');
            out_box_name = new string[Convert.ToByte(read[0])];
            out_box_value = new int[Convert.ToByte(read[0])];
            for (int i = 0; i < out_box_name.Length; i++)
            {
                out_box_name[i] = read[i + 1].ToString();
            }

            r = "";
            Console.WriteLine("鍵入「2-1轉移棒」的名稱及小圓盤名稱:");
            do
            {
                r += Console.ReadLine() + " ";
                times++;
                Console.Write("Continue?(1/0):");
            } while (Convert.ToByte(Console.ReadLine()) == 1);
            read = r.Split(' ');
            transform2_1 = new string[times, 4];
            for (int y = 0; y < times; y++)
                for (int x = 0; x < 4; x++)
                    transform2_1[y, x] = read[x + 4 * y];

            times = 0;
            r = "";
            Console.WriteLine("鍵入「1-1轉移棒」的名稱及小圓盤名稱:");
            do
            {
                r += Console.ReadLine() + " ";
                times++;
                Console.Write("Continue?(1/0):");
            } while (Convert.ToByte(Console.ReadLine()) == 1);
            read = r.Split(' ');
            transform1_1 = new string[times, 3];
            for (int y = 0; y < times; y++)
                for (int x = 0; x < 3; x++)
                    transform1_1[y, x] = read[x + 3 * y];

            
            Console.WriteLine("轉移棒與小圓盤的關係:");
            for (int y = 0; y < transform2_1.GetLength(0); y++)
                for (int x = 0; x < 4; x++)
                {
                    if (x == 0)
                        Console.Write(transform2_1[y, x] + ": ");
                    else
                        Console.Write(transform2_1[y, x] + " ");
                }
            for (int y = 0; y < transform1_1.GetLength(0); y++)
                for (int x = 0; x < 3; x++)
                {
                    if (x == 0)
                        Console.Write(transform1_1[y, x] + ": ");
                    else
                        Console.Write(transform1_1[y, x] + " ");
                }

            Console.WriteLine("\n小圓盤與轉移棒的關係:");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)//輸出in box name與轉移棒的關係
                {
                    for (int j = 0; j < in_box_name.Length; j++)
                    {
                        Console.Write(in_box_name[j] + ": ");
                        for (int y = 0; y < transform1_1.GetLength(0); y++)
                            for (int x = 0; x < 3; x++)
                            {
                                if (transform1_1[y, x] == in_box_name[j])
                                    Console.Write(transform1_1[y, 0] + " ");
                            }
                        for (int y = 0; y < transform2_1.GetLength(0); y++)
                            for (int x = 0; x < 4; x++)
                            {
                                if (transform2_1[y, x] == in_box_name[j])
                                    Console.Write(transform2_1[y, 0] + " ");
                            }
                    }
                }
                if (i == 1)//輸出box name與轉移棒的關係
                {
                    for (int j = 0; j < box_name.Length; j++)
                    {
                        Console.Write(box_name[j] + ": ");
                        for (int y = 0; y < transform1_1.GetLength(0); y++)
                            for (int x = 0; x < 3; x++)
                            {
                                if (transform1_1[y, x] == box_name[j])
                                    Console.Write(transform1_1[y, 0] + " ");
                            }
                        for (int y = 0; y < transform2_1.GetLength(0); y++)
                            for (int x = 0; x < 4; x++)
                            {
                                if (transform2_1[y, x] == box_name[j])
                                    Console.Write(transform2_1[y, 0] + " ");
                            }
                    }
                }
                if (i == 2)//輸出out box name與轉移棒的關係
                {
                    for (int j = 0; j < out_box_name.Length; j++)
                    {
                        Console.Write(out_box_name[j] + ": ");
                        for (int y = 0; y < transform1_1.GetLength(0); y++)
                            for (int x = 0; x < 3; x++)
                            {
                                if (transform1_1[y, x] == out_box_name[j])
                                    Console.Write(transform1_1[y, 0] + " ");
                            }
                        for (int y = 0; y < transform2_1.GetLength(0); y++)
                            for (int x = 0; x < 4; x++)
                            {
                                if (transform2_1[y, x] == out_box_name[j])
                                    Console.Write(transform2_1[y, 0] + " ");
                            }
                    }
                }
            }
            Console.WriteLine();
            do
            {
                Console.Write("鍵入將放權杖的小圓盤名稱:");
                r = Console.ReadLine();
                Console.WriteLine("查看各個小圓盤權杖的情況:");
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < in_box_name.Length; j++)
                        {
                            if (in_box_name[j] == r)
                                in_box_value[j]++;
                            Console.Write(in_box_name[j] + ":" + in_box_value[j] + " ");
                        }
                    }
                    if (i == 1)
                    {
                        for (int j = 0; j < box_name.Length; j++)
                        {
                            if (box_name[j] == r)
                                box_value[j]++;
                            Console.Write(box_name[j] + ":" + box_value[j] + " ");
                        }
                    }
                    if (i == 2)
                    {
                        for (int j = 0; j < out_box_name.Length; j++)
                        {
                            if (out_box_name[j] == r)
                                out_box_value[j]++;
                            Console.Write(out_box_name[j] + ":" + out_box_value[j] + " ");
                        }
                    }
                }

                Console.WriteLine("\n執行轉移棒.");

                for (int y = 0; y < transform1_1.GetLength(0); y++)
                {
                    bool transform = false;
                    for (int j = 0; j < in_box_name.Length; j++)
                    {
                        if (transform1_1[y, 1] == in_box_name[j] && in_box_value[j] == 1)
                        {
                            in_box_value[j] = 0;
                            transform = true;
                        }
                    }
                    for (int j = 0; j < box_name.Length; j++)
                    {
                        if (transform1_1[y, 1] == box_name[j] && box_value[j] == 1)
                        {
                            box_value[j] = 0;
                            transform = true;
                        }
                    }
                    for (int j = 0; j < out_box_name.Length; j++)
                    {
                        if (transform1_1[y, 1] == out_box_name[j] && out_box_value[j] == 1)
                        {
                            out_box_value[j] = 0;
                            transform = true;
                        }
                    }
                    if (transform)
                    {
                        for (int j = 0; j < in_box_name.Length; j++)
                        {
                            if (transform1_1[y, 2] == in_box_name[j])
                            {
                                in_box_value[j] = 1;
                                transform = false;
                            }
                        }
                        for (int j = 0; j < box_name.Length; j++)
                        {
                            if (transform1_1[y, 2] == box_name[j])
                            {
                                box_value[j] = 1;
                                transform = false;
                            }
                        }
                        for (int j = 0; j < out_box_name.Length; j++)
                        {
                            if (transform1_1[y, 2] == out_box_name[j])
                            {
                                out_box_value[j] = 1;
                                transform = false;
                            }
                        }
                    }
                }

                int[] register = new int[3];
                for(int y=0;y<transform2_1.GetLength(0);y++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < in_box_name.Length; j++)
                        {
                            if (transform2_1[y, i+1] == in_box_name[j])
                            {
                                register[i] = j;
                            }
                        }
                        for (int j = 0; j < box_name.Length; j++)
                        {
                            if (transform2_1[y, i+1] == box_name[j])
                            {
                                register[i] = j+100;
                            }
                        }
                        for (int j = 0; j < out_box_name.Length; j++)
                        {
                            if (transform2_1[y, i+1] == out_box_name[j])
                            {
                                register[i] = j+200;
                            }
                        }

                    }
                    //bug處
                    bool a=false, b=false;
                    for(int i=0;i<2;i++)
                    {
                        switch (register[i] / 100)
                        {
                            case 0:
                                if(in_box_value[register[i]]==1)
                                {
                                    if (i == 0)
                                        a = true;
                                    else if (i == 1)
                                        b = true;
                                }
                                break;
                            case 1:
                                if (box_value[register[i]%100] == 1)
                                {
                                    if (i == 0)
                                        a = true;
                                    else if (i == 1)
                                        b = true;
                                }
                                break;
                            case 2:
                                if (out_box_value[register[i] % 200] == 1)
                                {
                                    if (i == 0)
                                        a = true;
                                    else if (i == 1)
                                        b = true;
                                    out_box_value[register[i] % 200] = 0;
                                }
                                break;
                        }
                    }
                    if(a&&b)
                    {
                        for(int i = 0; i < 2; i++)
                        {
                            switch(register[i]/100)
                            {
                                case 0:
                                    in_box_value[register[i]] = 0;
                                    break;
                                case 1:
                                    box_value[register[i]%100] = 0;
                                    break;
                                case 2:
                                    out_box_value[register[i]%200] = 0;
                                    break;
                            }
                        }
                        
                        switch(register[2]/100)
                        {
                            case 0:
                                in_box_value[register[2] % 100] = 1;
                                break;
                            case 1:
                                box_value[register[2] % 100] = 1;
                                break;
                            case 2:
                                out_box_value[register[2] % 100] = 1;
                                break;
                        }
                    }
                }
                Console.WriteLine("查看各個小圓盤權杖的情況:");
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < in_box_name.Length; j++)
                        {
                            Console.Write(in_box_name[j] + ":" + in_box_value[j] + " ");
                        }
                    }
                    if (i == 1)
                    {
                        for (int j = 0; j < box_name.Length; j++)
                        {
                            Console.Write(box_name[j] + ":" + box_value[j] + " ");
                        }
                    }
                    if (i == 2)
                    {
                        for (int j = 0; j < out_box_name.Length; j++)
                        {
                            Console.Write(out_box_name[j] + ":" + out_box_value[j] + " ");
                        }
                    }
                }
                Console.Write("\nContinue?(1/0):");
            } while (Convert.ToByte(Console.ReadLine()) == 1);
        }
    }
}