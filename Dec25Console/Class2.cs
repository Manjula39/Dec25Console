using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Console
{

    class Node { public int data; public Node next; };
    class LinkedList { public Node head;
        public LinkedList() { head = null; } };
    class implementation
    {
        static void Main(string[] args)
        {
            LinkedList mylist = new LinkedList();
            Node first = new Node();
            first.data = 10;   first.next = null;
            mylist.head = first;
            Node second = new Node();   second.data = 20;    second.next = null;
            first.next = second;
            Node third = new Node();  third.data = 30;       third.next = null;
            second.next = third;
        }
    }

        }