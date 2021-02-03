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

            Console.WriteLine("Press Any Key to End");
            Console.ReadKey();



        }

        private static string AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
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
