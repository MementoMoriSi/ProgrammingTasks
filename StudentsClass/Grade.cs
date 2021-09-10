using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsClass
{
    class Grade
    {
        private char letterGrade;
        public char LetterGrade {
            get
            {
                return letterGrade;
            }
            private set
            {
                if (letters.Contains(value))
                    letterGrade = value;
                else
                    Console.WriteLine("Invalid letter!");
            }
        }

        private int numericalGrade;
        public int NumericalGrade {
            get
            {
                return numericalGrade;
            }
            private set
            {
                if (value >= 0 && value <= 100)
                {
                    numericalGrade = value;
                    GradeAccordihgNumber(numericalGrade);
                }
                else
                    Console.WriteLine("Invalid number!");
            }
        }
    

        private List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'F' };

        public Grade( int numericalGrade)
        {
            NumericalGrade = numericalGrade;
        }

        public void GradeAccordihgNumber(int numericalGrade)
        {
            if (numericalGrade >= 90 && numericalGrade <= 100)
                LetterGrade = 'A';
            else if (numericalGrade >= 80 && numericalGrade < 90)
                LetterGrade = 'B';
            else if (numericalGrade >= 70 && numericalGrade < 80)
                LetterGrade = 'C';
            else if (numericalGrade >= 60 && numericalGrade < 70)
                LetterGrade = 'D';
            else
                LetterGrade = 'F';

        }

        public override string ToString()
        {
            return $"{numericalGrade} or {letterGrade}";
        }

    }      
}
