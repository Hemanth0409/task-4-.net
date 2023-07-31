using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public partial class Program

    {
        public void LinkedList()
        {
            LinkedList<int> Lst = new LinkedList<int>();
            Lst.AddLast(9);
            Lst.AddFirst(5);
            Lst.AddFirst(2);
            Lst.AddLast(4);
            Lst.AddLast(1);
            Lst.AddFirst(8);
           
            Console.WriteLine("Linked List elements are: ");
            foreach (int i in Lst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
