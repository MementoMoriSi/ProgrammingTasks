using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsClass
{
    class Student
    {
        private readonly string name;
        private readonly string lastName;
        public string FullName { get { return $"{name}  {lastName}"; } }
        public int TestCount { get; private set; }
        public Grade GPA { get; private set; }

        private List<Grade> grades = new List<Grade>();

        public Student(string name, string lastName, int testCount)
        {
            this.name = name;
            this.lastName = lastName;
            TestCount = testCount;
        }

        public void GradeForEachTest()
        {
            int j;
            for (int i = 0; i < TestCount; i++)
            {
                j = i;
                Console.WriteLine($"Enter numeric grade for test #{++j}: ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out int numericGrade))
                    grades.Add(new Grade(numericGrade));
                else
                {
                    Console.WriteLine("You entered invalid number!");
                    return;
                }
            }

            AverageGrade();
        }

        private void AverageGrade()
        {
            int allGrades = 0;
            for (int i = 0; i < TestCount; i++)
            {
                allGrades += grades[i].NumericalGrade;
            }

            GPA = new Grade(allGrades / TestCount);
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}
