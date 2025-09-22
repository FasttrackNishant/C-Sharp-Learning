using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Properties
{
    public class Student
    {
        private int _Id;
        private string _Name;
        private string _FatherName;
        private int _SubjectMarks = 100;


        public int Id
        {
            set
            {
                //here we can check valiation
                if (value <= 0)
                {
                    Console.WriteLine($"Id can't be zero");
                }
                else
                {
                    this._Id = value;
                }
            }
            get
            {
                return this._Id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine($"Please enter the valid string");
                }
                else
                {
                    this._Name = value;
                }
            }
            get
            {
                return this._Name;
            }
        }
        public string FatherName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine($"Please enter the valid string");
                }
                else
                {
                    this._FatherName = value;
                }
            }
            get
            {
                return this._FatherName;
            }
        }

        public int SubjectMarks
        {
            get { return this._SubjectMarks; }
        }

        // auto implemented properties

        public string StudentName { get; private set; }
        public Student(string StudentName)
        {
            this.StudentName = StudentName; 
            //now this can't be set by another class member

        }

    }
}