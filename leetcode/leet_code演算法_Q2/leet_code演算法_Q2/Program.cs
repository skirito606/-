using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code演算法_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random b = new Random();
            for(int i=0;i<b.Next(1,100);i++)
                a.Add(b.Next(1,100));
            a.Sort();
            int[] d = new int[a.Count];
            a.CopyTo(d);
            a.Clear();
            for (int i = 0; i < d.Length; i++)
                Console.WriteLine(d[i]);
            if (d.Length % 2 == 0)
                Console.WriteLine((d[d.Length / 2] + d[d.Length / 2 - 1] )/ 2);
            else
                Console.WriteLine(d[(d.Length) / 2]);
            Console.ReadKey();
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        int carry = 0;
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            if (l1 == null && l2 == null && carry == 0)
            {
                result = null;
                return result;
            }
            else
            {
                if (l1 == null)
                    l1 = new ListNode(0);
                if (l2 == null)
                    l2 = new ListNode(0);
                result.val = (l1.val + l2.val + carry) % 10;
                carry = (l1.val + l2.val + carry) / 10;
                result.next = AddTwoNumbers(l1.next, l2.next);

                return result;
            }
        }
    }
}
