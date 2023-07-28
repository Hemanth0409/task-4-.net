using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public partial class Program
    {
        public void hashTable ()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("Id", 5);
            hashTable.Add("Name","Hemanth");
            hashTable.Add("Age",21);
            foreach (DictionaryEntry data in hashTable)
            {
                Console.WriteLine("{0}:{1}",data.Key,data.Value);
            }
        }
        static void Main(string[] args)
        {
            // //Hash Table
            //Program hashTable= new Program();
            //hashTable.hashTable();

            ////Queue 
            //prg2 queue = new prg2();
            //queue.Queue();

            ////LinkedList
            //LinkedList1 linkedList = new LinkedList1();
            //linkedList.LinkedList();

            ////HashSet
            //Hashset hashset = new Hashset();
            //hashset.HashSet();

            //attendance& mark
            TraineeDetails mark = new TraineeDetails();
            mark.GetDetails();

            Console.ReadKey();  
        }
    }
}
