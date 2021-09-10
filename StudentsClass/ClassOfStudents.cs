using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsClass
{
    class ClassOfStudents
    {
        public int NumberOfStudents { get; private set; }
        private readonly int testsCount;
        private List<Student> students = new List<Student>();

        public ClassOfStudents(int numberOfStudents)
        {
            NumberOfStudents = numberOfStudents;

            Console.Write("How many test administered to the students?: ");
            string str = Console.ReadLine();
            this.testsCount = int.TryParse(str, out int value) ? value : 0;
            EnterStudentsInfo();
        }

        private void EnterStudentsInfo()
        {
            string name;
            string lastName;

            int j = 0;

            for (int i = 0; i < NumberOfStudents; i++)
            {
                j = i;
                Console.Write($"Enter the name of student #{++j}: ");
                name = Console.ReadLine();
                Console.Write($"Enter the last name of student #{j}: ");
                lastName = Console.ReadLine();

                students.Add(new Student(name, lastName, testsCount));
                students[i].GradeForEachTest();
            }
        }

        public void StudentsGPAs()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student}'s GPA is {student.GPA}");
            }
        }




    }
}
