using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{
    public class LSClass
    {
        int Lsearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i]) return i + i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            LSClass ls = new LSClass();
            int[] nums = { 90, 60, 86, 390, 20, 55 };
            int n, result; Console.WriteLine("what to search or target");
            n = Convert.ToInt32(Console.ReadLine());
            result = ls.Lsearch(nums, n);
            if (result != -1) { Console.WriteLine("the target is found  " + n + "   position is " + result); }
            else
                Console.WriteLine("target not found");
            Console.ReadLine();
        }
    }
}

