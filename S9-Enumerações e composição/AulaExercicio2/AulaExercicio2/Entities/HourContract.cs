using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio2.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
        public override string ToString()
        {
            return "Date: "
                + Date
                + ", Value per hour: "
                + ValuePerHour
                + ", Hours of work: "
                + Hours;
        }
    }
}
