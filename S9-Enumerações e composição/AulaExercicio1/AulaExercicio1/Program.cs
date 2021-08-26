using AulaExercicio1.Entities;
using AulaExercicio1.Entities.Enums;
using System;

namespace AulaExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}
