using System;


namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            PostOffice office = new PostOffice();
            var rand = new Random();
            for (byte i=0; i<8; i++)
            {                
                byte seed = (byte) rand.Next(0, 3);
                Employee employee = new Employee();
                if (seed == 0)
                {
                    employee = new Postman();
                }
                if (seed == 1)
                {
                    employee = new Operator();
                }
                if (seed == 2)
                {
                    employee = new Cashier();
                }
                employee.Name = GeneratingName(rand);
                employee.DateOfEmployment = GeneratingDate(rand);
                office.Employees.Add(employee);
            }
            office.Poll();
            Console.ReadKey();
        }
        static DateTime GeneratingDate(Random rand)
        {
            string year = Convert.ToString(1995 + rand.Next(0, 22));
            string month = Convert.ToString(rand.Next(1, 13));
            int maximumDays = DateTime.DaysInMonth(Convert.ToInt32(year), Convert.ToInt32(month));
            string day = Convert.ToString(rand.Next(1, maximumDays + 1));
            return DateTime.Parse($"{day}/{month}/{year}");
        }
        static string GeneratingName(Random rand)
        {
            string[] namesList = new string[] { "Эдуард", "Вадим", "Владислав", "Ирина",
                "Александр", "Алексей", "Дмитрий", "Денис", "Никита", "Артём",
                "Диана", "Виктор", "Аня", "Роман", "Станислав", "Иван", "Кирилл", "Елизавета", 
                "Ярослав", "Сергей", "Владимир" };
            byte i = (byte)rand.Next(0, namesList.Length);
            return namesList[i];
        }
    }
}
