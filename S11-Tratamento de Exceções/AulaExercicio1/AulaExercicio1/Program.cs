using AulaExercicio1.Entities;
using System;

namespace AulaExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check in date dd/mm/yyyy: ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check out date dd/mm/yyyy: ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("erro na data, check in não pode ser depois de checkout")
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
        }
    }
}
