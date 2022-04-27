using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enet Group Name:");
            string groupnumber=Console.ReadLine();
            Console.Write("Enet Group Limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            Group group = new Group(groupnumber, limit);

            for (int i = 0; i < group.GroupLimit; i++)
            {
                Console.Write("Enter Name:");
                string name = Console.ReadLine();
                Console.Write("Enter Surname:");
                string surname = Console.ReadLine();
                Student student = new Student(name, surname);
                group.AddStudent(student);
            }
            group.GetStudents();
        }
    }
}
