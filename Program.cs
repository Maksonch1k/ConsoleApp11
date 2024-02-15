namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // массив ссылок на базовый класс
            Employee[] employees = new Employee[5];

            // инициализация объектов различных классов
            employees[0] = new Manager("Андрей", "Бабчинецкий", new DateTime(1990, 5, 15), 50000, 120);
            employees[1] = new Engineer("Максим", "Коробка", new DateTime(1985, 10, 8), 60000, 5);
            employees[2] = new Manager("Даниил", "Ефаров", new DateTime(1988, 3, 25), 55000, 80);
            employees[3] = new Engineer("Даниил", "Слипенчук", new DateTime(1992, 7, 3), 65000, 3);
            employees[4] = new Employee("Евгений", "Яшин", new DateTime(1995, 12, 20), 70000);

            // Вывод информации о  объекте и вычисление  величины дохода
            Console.WriteLine("Employee Information:");
            Console.WriteLine("=====================");

            double totalIncome = 0;
            double maxManagerIncome = 0;

            foreach (Employee emp in employees)
            {
                emp.DisplayInfo();
                double income = emp.CalculateIncome(1.2);
                Console.WriteLine($"Income: {income}");
                Console.WriteLine("=====================");

                totalIncome += income;

                if (emp is Manager manager)
                {
                    double managerIncome = manager.CalculateIncome(1.2);
                    if (managerIncome > maxManagerIncome)
                    {
                        maxManagerIncome = managerIncome;
                    }
                }
            }

            Console.WriteLine($"Total Income of all employees: {totalIncome}");
            Console.WriteLine($"Maximum Income for Managers: {maxManagerIncome}");
        }
    }
}
    
