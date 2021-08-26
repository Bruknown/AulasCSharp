using AulaExercicio2.Entities;
using System;
using System.Collections.Generic;

namespace AulaExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many employees will you register? ");
            List<Employee> employees = new List<Employee>();
            OutSourcedEmployee outsrcemp = new OutSourcedEmployee();
            int quant = int.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Employee number " + (i + 1) + "'s name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Outsourced? (y/n)");
                string outsrc = Console.ReadLine();
                int additional = 0;
                if (outsrc.Equals("y"))
                {
                    Console.WriteLine("Additional charges? ");
                    additional = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("how many hours of work? ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("how much is he paid per hour? ");
                int valueperhour = int.Parse(Console.ReadLine());

                if (outsrc.Equals("y"))
                {
                    employees.Add(new OutSourcedEmployee(name, hours, valueperhour, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valueperhour));
                }
            }

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.Payment(emp.Hours, emp.ValuePerHour).ToString());
            }
            foreach(OutSourcedEmployee outs in employees)
            {
                Console.WriteLine(outs.Payment(outs.Hours, outs.ValuePerHour).ToString());
            }
        }
    }
}
