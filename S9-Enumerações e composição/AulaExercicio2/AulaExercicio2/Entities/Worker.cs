using AulaExercicio2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio2.Entities
{
    class Worker
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; private set; }
        public Department Dept { get; set; }
        public HourContract[] Contract { get; private set; }


        public Worker(string nome, WorkerLevel level, double baseSalary)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
        }
        public Worker(string nome, WorkerLevel level, double baseSalary, Department dept, HourContract[] contract)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Dept = dept;
            AddContract(contract);
        }
        public double Income(int month, int year)
        {
            double income = 0;
            for (int i = 0; i < Contract.Length; i++)
            {
                if (Contract[i].Date.Month.Equals(month)
                 && Contract[i].Date.Year.Equals(year))
                {
                    income += Contract[i].totalValue();
                }
            }
            return BaseSalary + income;
        }

        public void RemoveContract(HourContract contract)
        {
            for (int i = 0; i < Contract.Length; i++)
            {
                if (Contract[i].Equals(contract))
                {
                    Contract[i].Date = DateTime.MinValue;
                    Contract[i].Hours = 0;
                    Contract[i].ValuePerHour = 0;
                }
            }
        }

        public void AddContract(HourContract[] contract)
        {
            Contract = contract;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Level: "
                + Level
                + ", Salary: "
                + BaseSalary;
        }
    }
}
