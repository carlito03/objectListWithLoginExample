using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace logInexample.Models
{
    public class Student
    {
        #region Fields
        private int studentID;
        private string studentFirstName;
        private string studentLastName;
        private int studentAge;
        #endregion

        #region Properties
        public int StudentID { get { return studentID; } set { studentID = value; } }
        public string StudentFirstName { get { return studentFirstName; } set { studentFirstName = value; } }
        public string StudentLastName { get { return studentLastName; } set { studentLastName = value; } }
        public int StudentAge { get { return studentAge; } set { studentAge = value; } }
        #endregion

        public Student()
        {
            //sets reasonable initial values
            studentID = 0;
            studentFirstName = "";
            studentLastName = "";
            studentAge = 0;
        }

        static public List<Student> GetStudentList()
        {
            List<Student> thelist = new List<Student>();

            //Create a few objects for our list 
           
            Student obj = new Student();
            Student objtwo = new Student();

            obj.studentID = 92899;
            obj.studentFirstName = "Carlos";
            obj.studentLastName = "Roman";
            obj.studentAge = 34;

            objtwo.studentID = 1111;
            objtwo.studentFirstName = "Bugs";
            objtwo.studentLastName = "Bunny";
            objtwo.studentAge = 12;

            thelist.Add(obj);
            thelist.Add(objtwo);
        
            return thelist;

        }

    }
}