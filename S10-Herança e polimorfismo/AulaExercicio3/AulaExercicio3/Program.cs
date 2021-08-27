using AulaExercicio3.Entities;
using System;
using System.Collections.Generic;

namespace AulaExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many products do you want to insert? ");

            List<Product> products = new List<Product>();

            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Common, used or imported? (c,u,i) ");
                string choice = Console.ReadLine();
                string name = "";
                double price = 0;
                switch (choice)
                {
                    case "c":
                        Console.WriteLine("Product name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Product price? ");
                        price = double.Parse(Console.ReadLine());
                        products.Add(new Product(name, price));
                        break;
                    case "u":
                        Console.WriteLine("Product name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Product price? ");
                        price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Product fabrication date? ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        products.Add(new UsedProduct(name, price, date));
                        break;
                    case "i":
                        Console.WriteLine("Product name? ");
                        name = Console.ReadLine();
                        Console.WriteLine("Product price? ");
                        price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Product extra fee? ");
                        double extraPrice = double.Parse(Console.ReadLine());

                        products.Add(new ImportedProduct(name, price, extraPrice));
                        break;
                }
            }

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag(prod.Name, prod.Price));
            }
        }
    }
}
