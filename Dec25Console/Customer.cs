using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{
    public class Customer
    {
        int cID;
        string cName;
        public Customer() { Console.WriteLine("current C is called before line14"); }
        public Customer(int id) : this() { this.cID = id; }
        static Customer() { Console.WriteLine("always before Main() "); Console.WriteLine("we once in life time values in SC"); }
        public void display() { this.cID = 10;
            this.cName = "harry"; Console.WriteLine("customer Display()"); }
        static void Main(string[] args) //line15
        {//only line15
            // customer c = new customer(); //line 13
            Customer cc = new Customer(10); //line 13,14
            cc.display();//explicit
        }
    }
}
        
    
