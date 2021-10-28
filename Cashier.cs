using System;


namespace Lab6
{
    class Cashier : Employee
    {
        public override string WhatYouDo()
        {
            return "Пополняю транспортные карты.";
        }

        public override string WorkTime() // days
        {
            var span = DateTime.Now.Subtract(DateOfEmployment);
            return $"{(uint)span.Days} дней (дня).";
        }
    }
}
