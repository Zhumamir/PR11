using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = CreateEmployee("Амир Жумагалиев", Vacancies.Developer, new int[] { 17, 4, 2023 }, 200000);
            PrintEmployeeInfo(employee1);
        }
        static Employee CreateEmployee(string name, Vacancies vacancy, int[] hiringDate, int salary)
        {
            Employee employee;
            employee.Name = name;
            employee.Vacancy = vacancy;
            employee.HiringDate = hiringDate;
            employee.Salary = salary;
            return employee;
        }
        static void PrintEmployeeInfo(Employee employee)
        {
            Console.WriteLine("Имя: " + employee.Name);
            Console.WriteLine("Вакансия: " + employee.Vacancy);
            Console.WriteLine("Дата приема на работу: " + string.Join(".", employee.HiringDate));
            Console.WriteLine("Зарплата: " + employee.Salary);
        }
    }
    public enum Vacancies
    {
        Manager,
        Developer,
        Designer,
        QA
    }

    public struct Employee
    {
      
        public string Name;
        public Vacancies Vacancy;
        public int[] HiringDate;
        public int Salary;
    }
}
