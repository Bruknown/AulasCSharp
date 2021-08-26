using AulaExercicio2.Entities;
using AulaExercicio2.Entities.Enums;
using System;

namespace AulaExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Department name: ");
            Department dept = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Level (junior,mid,senior): ");
            string level = Console.ReadLine();
            Console.WriteLine("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(name, Enum.Parse<WorkerLevel>(level), salary);
            Console.WriteLine("Worker Data: " + worker);

            Console.WriteLine("====================");
            Console.WriteLine("How many contracts for this worker?");

            HourContract[] contracts = new HourContract[int.Parse(Console.ReadLine())];

            for (int i = 0; i < contracts.Length; i++)
            {
                Console.WriteLine("enter contract N" + (i + 1) + "'s date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("enter contract N" + (i + 1) + "'s ratings p/ hour: ");
                double ratings = double.Parse(Console.ReadLine());

                Console.WriteLine("enter contract N" + (i + 1) + "'s hours of work: ");
                int hours = int.Parse(Console.ReadLine());

                contracts[i] = new HourContract(date, ratings, hours);
                Console.WriteLine(contracts[i]);
            }
            worker = new Worker(name, Enum.Parse<WorkerLevel>(level), salary, dept, contracts);
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("enter month and year to calculate income ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.WriteLine("Total income this month: " + worker.Income(date.Month, date.Year));
            }
        }
    }
}
