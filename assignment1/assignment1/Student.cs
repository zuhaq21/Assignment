using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class Student
    {
        public void addStudent(String name, String semester, String cgpa, String department, String university, String id)
        {
            using(StreamWriter writetext = File.AppendText("D:/Uni/BSE-5/VP/Assignments/Students.txt"))
            {
                String attendence = "A";
                writetext.WriteLine(name);
                writetext.WriteLine(id);
                writetext.WriteLine(semester);
                writetext.WriteLine(cgpa);
                writetext.WriteLine(department);
                writetext.WriteLine(university);
                writetext.WriteLine(attendence);
            }
        }

        public string setId()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            var FormNumber = BitConverter.ToUInt32(buffer, 0) ^ BitConverter.ToUInt32(buffer, 4) ^ BitConverter.ToUInt32(buffer, 8) ^ BitConverter.ToUInt32(buffer, 12);
            return FormNumber.ToString("X");
        }

        //public void deleteStudent()
        //{

        //}
        //public void searchById()
        //{

        //}
        //public void searchByName()
        //{

        //}
        //public void displayStudents()
        //{

        //}
        //public void displayTopThree()
        //{

        //}
    }
}
