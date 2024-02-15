using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Engineer : Employee
    {
        private int projectsCount; // Дополнительное поле для количества разработанных проектов

        // Конструктор
        public Engineer(string firstName, string lastName, DateTime birthDate, double minSalary, int projectsCount)
            : base(firstName, lastName, birthDate, minSalary)
        {
            this.projectsCount = projectsCount;
        }

        // Переопределенные методы
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Projects Count: {projectsCount}");
        }

        public override double CalculateIncome(double k)
        {
            // Увеличиваем доход инженера на 4.8 * количество проектов
            return base.CalculateIncome(k) + 4.8 * projectsCount;
        }
    }
}

