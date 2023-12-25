using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{
    internal class Program
    {
        static void Fun1()
        {

        }
        public string Display()
        {
            return "hello";
        }
        public Program()
        {
        }
        static void Main(string[] args)
        {
            Fun1();
            Program p = new Program();
            string s = p.Display();
        }
    }
        }
