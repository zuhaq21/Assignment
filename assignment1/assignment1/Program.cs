    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            char exitChoice;
            int choice;
            do
            {
                String name, semester, cgpa, department, university, id;
                Console.Write("Press 1 to add student.\n");
                Console.Write("Press 2 to search for student. \n");
                Console.Write("Press 3 to delete a record of a student. \n");
                Console.Write("Press 4 to check top 4 students of class.\n");
                Console.Write("Press 5 to mark attendence.\n");
                Console.Write("Press 6 to view attendence\n");
                Console.Write("\t\t\t Enter your choice  \n");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter the Name Of Student:  ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter the semester of student:  ");
                    semester = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter the cgpa of student:  ");
                    cgpa = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter the department of student:  ");
                    department = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter the university of student:  ");
                    university = Convert.ToString(Console.ReadLine());
                    id = obj.setId();
                    obj.addStudent(name, semester, cgpa, department, university, id);

                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {

                }
                else if (choice == 5)
                {

                }
                else
                {

                }
                choice = 0;
                Console.WriteLine("Want to do again: y/n");
                exitChoice = Convert.ToChar(Console.Read());
            }
            while (exitChoice == 'y' || exitChoice == 'Y');
        }
    }
}
