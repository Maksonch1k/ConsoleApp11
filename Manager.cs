using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Manager : Employee
    {
        private double salesVolume; 

        // Конструктор
        public Manager(string firstName, string lastName, DateTime birthDate, double minSalary, double salesVolume)
            : base(firstName, lastName, birthDate, minSalary)
        {
            this.salesVolume = salesVolume;
        }

        
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sales Volume: {salesVolume} tons");
        }

        public override double CalculateIncome(double k)
        {
            const double threshold = 100; 
            double income = base.CalculateIncome(k);

            
            if (salesVolume > threshold)
            {
                income += 0.01 * salesVolume;
            }

            return income;
        }
    }
}

