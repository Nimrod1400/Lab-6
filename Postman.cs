using System;


namespace Lab6
{
    class Postman : Employee
    {
        public override string WhatYouDo()
        {
            return "Разношу почту, не мешайте.";
        }

        public override string WorkTime() // years
        {
            var span = DateTime.Now.Subtract(DateOfEmployment);
            return $"{(uint)(span.Days / 365)} лет (года).";
        }
    }
}
