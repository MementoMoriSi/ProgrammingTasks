using System;

namespace StudentsClass
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter number of students: ");
            string str = Console.ReadLine();
            int numberOfStudents = int.TryParse(str, out int value) ? value : 0;

            ClassOfStudents studentsClass = new ClassOfStudents(numberOfStudents);

            studentsClass.StudentsGPAs();



        }
    }
}
