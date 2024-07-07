using System;

class LetterGradeConversion
{
    static void Main()
    {
        Console.WriteLine("Enter a numerical grade between 0 and 100: ");
        int gradeNumber = Convert.ToInt32(Console.ReadLine());

        char letterAndGrade;

        if (gradeNumber >= 90)
        {
            letterAndGrade = 'A';
        }
        else if (gradeNumber >= 80)
        {
            letterAndGrade = 'B';
        }
        else if (gradeNumber >= 70)
        {
            letterAndGrade = 'C';
        }
        else if (gradeNumber >= 60)
        {
            letterAndGrade = 'D';
        }
        else
        {
            letterAndGrade = 'F';
        }

        Console.WriteLine("The appropriate grade is : " + letterAndGrade);
    }
}
