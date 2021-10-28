using System;


namespace Lab6
{
    class Operator : Employee
    {
        public override string WhatYouDo()
        {
            return "Ищу посылку.";
        }

        public override string WorkTime() // months
        {
            var span = DateTime.Now.Subtract(DateOfEmployment);
            return $"{(uint)(span.Days / 30.44)} месяцев (месяца).";
        }
    }
}
