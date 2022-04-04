using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        
        public Student(string fullName, int Age,string groupNo)
        {
            FullName = fullName;
            this.Age = Age;
            GroupNo = groupNo;
        }
        private string _fullName { get; set; }

        private string _groupNo;
        public int Age { get; set; }

        public string FullName 
        {
            get
            { 
                return this._fullName; 
            }
             set 
            {
                if (value.Split(" ").Length == 2 && value.Split(" ")[1]!= "")
                {
                    this._fullName = value;
                }
                else
                {

                }
            }
        
        }

        public string GroupNo
        {
            get
            {
                return this._groupNo;
            }
             set
            {
                if (value.Length == 4 && char.IsLetter(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) )
                {
                    this._groupNo = value;
                }
                else
                {
                    
                }

            }

        }
        



    }
}
