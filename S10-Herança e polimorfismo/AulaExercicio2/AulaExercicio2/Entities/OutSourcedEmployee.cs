using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio2.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharges { get; set; }

        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharges)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharges = additionalCharges;
        }

        public override double Payment(int hours, double valuePerHour)
        {
            AdditionalCharges += AdditionalCharges * 10/100;
            return hours * valuePerHour + AdditionalCharges;
        }
    }
}
