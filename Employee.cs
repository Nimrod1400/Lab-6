using System;


namespace Lab6
{
    class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfEmployment { get; set; }
        

        
        public string Say()
        {
            return Name;
        }

        public virtual string WorkTime()
        {
            return "";
        }

        public virtual string WhatYouDo()
        {
            return "";
        }
    }
}
