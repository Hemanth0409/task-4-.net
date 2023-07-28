using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    partial struct TraineeDetails
    {
        public int Id;
        public string Name;
        public int AttendanceDays;

        public void GetDetails()
        {
            int p = 0;
            int a = 0;
            Console.Write("Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Id = id;
            Console.Write("Name:");
            string name = Console.ReadLine();
            Name = name;
            Console.WriteLine("Total no of days:");
            int attendanceDays = Convert.ToInt32(Console.ReadLine());
            AttendanceDays = attendanceDays;
            for (int i = 0; i < attendanceDays; i++)
            {
               
                Console.Write($"Day{i} (p/a):");
                char val = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");
                if (val == 'p')
                {
                    p++;
                }
                else if (val == 'a')
                {
                    a++;
                }
            }
            Console.WriteLine("Number of days Present",p);
            Console.WriteLine("Number of days Absent", a);
        }
    }
}
