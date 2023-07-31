using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public partial class Program
    {
        public void Queue()
        {
            Queue<int> Q1 = new Queue<int>();
            Q1.Enqueue(1);
            Q1.Enqueue(2);
            Q1.Enqueue(3);
            Q1.Enqueue(4);

            Console.WriteLine("\n");
            Console.WriteLine("Queue:");

            Console.WriteLine("Number of Integer:{0}", Q1.Count);
            Console.WriteLine("\n");
            Console.WriteLine("****Befor dequeue****");
            foreach (int i in Q1)
            {
                Console.Write(i);
            }
            Q1.Dequeue();
            Console.WriteLine("\n");
            Console.WriteLine("****After dequeue****");
            foreach (int i in Q1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
