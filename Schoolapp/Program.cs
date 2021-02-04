using System;

namespace Schoolapp
{
    class Program
    {
        static void Main(string[] args)
        {

            //create first student

            Student FirstStudent = new Student();

            //get student info

            FirstStudent.StudentNum = AskForStudentNumber();
            FirstStudent.StudentFirstName = AskForStudentName("First");
            FirstStudent.StudentLastName = AskForStudentName("Last");
            FirstStudent.major = AskForMajor(FirstStudent.StudentFirstName);
            FirstStudent.Score1 = AskForExamScore(1);
            FirstStudent.Score2 = AskForExamScore(2);
            FirstStudent.Score3 = AskForExamScore(3);

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine(FirstStudent.ToString());

            Console.WriteLine("Press enter for next student");
            Console.ReadKey();

            //create second student

            Console.WriteLine("\nSecond Student \n");

            Student SecondStudent = new Student("6789", "Randall", "Frank");
            SecondStudent.major = AskForMajor(SecondStudent.StudentFirstName);
            SecondStudent.Score1 = AskForExamScore(1);
            SecondStudent.Score2 = AskForExamScore(2);
            SecondStudent.Score3 = AskForExamScore(3);

            Console.WriteLine("Second Student");
            Console.WriteLine(SecondStudent.ToString());

            Console.WriteLine("Press enter for next student");
            Console.ReadKey();

            Console.WriteLine("\nGetting Data From Database\n");

            //create third student
            Student ThirdStudent = new Student("4567", "Breakers", "Jeff", "History", 98, 90, 95);

            Console.WriteLine("Third Student");
            Console.WriteLine(ThirdStudent.ToString());

            Console.WriteLine("Press any key to end program");
            Console.ReadKey();


        }

        private static string AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;

            Console.WriteLine("Enter a value for score {0}:", whichOne);
            inValue = Console.ReadLine();
            aScore = int.Parse(inValue);
            return aScore;

        }

        private static string AskForMajor(string studentFirstName)
        {
            string inValue;
            Console.WriteLine("Enter {0}\'s Major: ");
            inValue = Console.ReadLine();
            return inValue;
        }

        private static string AskForStudentName(string whichOne)
        {
            string inValue;
            Console.WriteLine("Enter Students {0} Name: ", whichOne);
            inValue = Console.ReadLine();
            return inValue;

        }

        private static string AskForStudentNumber()
        {
            string inValue;
            Console.WriteLine("Enter Student ID Number: ");
            inValue = Console.ReadLine();
            return inValue;

        }
    }
}
