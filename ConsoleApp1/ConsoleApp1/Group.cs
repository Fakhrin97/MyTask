using System;

namespace ConsoleApp1
{
    internal class Group
    {
        public string No { get; set; }

        public int GroupLimit { get; set; }

        Student[] Students;

        public Group(string no, int groupLimit)
        {
            GroupLimit = groupLimit;
            No = no;
            Students = new Student[0];
        }
        public void AddStudent(Student student)
        {

            if (Students.Length < GroupLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }

        }
        public void GetStudents()
        {
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine($"Group Name:{No}");
            
            for (int i = 0; i < Students.Length; i++)
            {
                var item = Students[i];
                 Console.WriteLine($"Student Name:{item.Name} Surname:{item.SurName}");
            }
            //foreach (Student item in Students)
            //{
            //    Console.WriteLine($"Student Name:{item.Name} Surname:{item.SurName}");

            //}
        }
    }
}
