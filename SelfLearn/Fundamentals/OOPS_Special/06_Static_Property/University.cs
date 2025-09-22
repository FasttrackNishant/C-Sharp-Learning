using System;

namespace _06_Static_Property
{
    public class University
    {
        private static string UniversityName;
        private static string DepartmentName;
        private int Age;
        // public static int _Age { set { Age = value; } }
        // An object reference is required for the non-static field, method, or property 'University.Age
        



        public static string _UniversityName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine($"Non Empty Dalo");
                else
                    UniversityName = value;
            }
            get { return UniversityName; }
        }

        public static string _DepartmentName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine($"Empty Hain Boss");
                }
                else
                    DepartmentName = value;
            }
            get { return DepartmentName; }
        }


    }
}


/*
here we are initializeting static property with the static variables 

*/