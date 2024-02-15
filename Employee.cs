using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Employee
    {
        // Скрытые поля
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private double minSalary;

        // Конструкторы
        public Employee()
        {
            // Конструктор без параметров
        }

        public Employee(string firstName, string lastName, DateTime birthDate, double minSalary)
        {
            // Конструктор с параметрами
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.minSalary = minSalary;
        }

        // Свойства
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public double MinSalary
        {
            get { return minSalary; }
            set { minSalary = value; }
        }

        // Виртуальные методы
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Min Salary: {minSalary}");
        }

        public virtual double CalculateIncome(double k)
        {
            return k * minSalary;
        }
    }

}

