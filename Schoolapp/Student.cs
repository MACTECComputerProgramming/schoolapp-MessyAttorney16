using System;
using System.Collections.Generic;
using System.Text;

namespace Schoolapp
{
    class Student
    {
        // fields/variable

        private string studentNum, studentLastName, studentFirstName, Major;
        private int score1, score2, score3;

        //constructor

        //default
        public Student()
        {

        }


        //constructor-one argument
        public Student(string sID) 
        {
            studentNum = sID;
        }

        //constructor-three arguments
        public Student(string sID, string lastName, string firstName)
        {
            studentNum = sID;
            studentLastName = lastName;
            studentFirstName = firstName;


        }

        public Student(string sID, string lastName, string firstName, string major, int score1, int score2, int score3)
        {
            this.studentNum = sID;
            this.studentLastName = lastName;
            this.studentFirstName = firstName;
            this.Major = major;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;


        }


        //properties

        public string StudentNum { get => studentNum; set => studentNum = value; }
        public string StudentLastName { get => studentLastName; set => studentLastName = value; }
        public string StudentFirstName { get => studentFirstName; set => studentFirstName = value; }
        public string major { get => major; set => major = value; }
        public string Score1 { get => Score1; set => Score1 = value; }
        public string Score2 { get => Score2; set => Score2 = value; }
        public string Score3 { get => Score3; set => Score3 = value; }




        //methods

        public double CalculatedAverage()
        {
            return (score1 + score2 + score3) / 3.0;

        }

        public override string ToString()
        {
            return "Name: " + studentFirstName + " " + studentLastName + "\nMajor: " + "\nScore Average: " + CalculatedAverage().ToString("F2");
        }

    }
}
