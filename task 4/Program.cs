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
        public void hashTable()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("Id", 5);
            hashTable.Add("Name", "Hemanth");
            hashTable.Add("Age", 21);
            Console.WriteLine("hashTable:");
            foreach (DictionaryEntry data in hashTable)
            {
                Console.WriteLine("{0}:{1}", data.Key, data.Value);
            }
        }
        static void Main(string[] args)
        {

            Program prg21 = new Program();
            prg21.hashTable();
            prg21.Queue();
            prg21.HashSet();
            prg21.LinkedList();

            TraineeDetails attendence = new TraineeDetails();   
            attendence.GetDetails();

            Console.ReadKey();
        }
    }
}
