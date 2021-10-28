using System;
using System.Collections.Generic;

namespace Lab6
{
    class PostOffice
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void Poll()
        {
            byte counter = 1;
            foreach (Employee employee in Employees)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Опрос работника под номером {counter}:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("А вас как зовут?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Меня зовут {employee.Say()}.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("А что вы делаете?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(employee.WhatYouDo());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("И давно вы тут работаете?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Я работую тут уже {employee.WorkTime()}");
                Console.WriteLine("\n");
                counter++;
            }
        }
    }
}
