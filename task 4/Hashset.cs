using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{

    public partial class Program

    {
        public void HashSet()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();
            Console.WriteLine("\n");
            Console.WriteLine("hashset:");
            Console.Write("Enter a Number:");
            int x=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("\n");
            for (int i = 0; i < x; i++)
            {
                evenNumbers.Add(i * 2);


                oddNumbers.Add((i * 2) + 1);
            }
        

            Console.Write("{0} evenNumbers elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);
            Console.WriteLine("\n");
            Console.Write(" {0} oddNumbers  elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            void DisplaySet(HashSet<int> collection)
            {
              
                foreach (int i in collection)
                {
                    Console.Write(" {0}", i);
                }
                
            }
        }
    }
}
