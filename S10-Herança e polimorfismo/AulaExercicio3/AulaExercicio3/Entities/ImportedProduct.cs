using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio3.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice(double price, double customFee)
        {
            return price + customFee;
        }

        public override string PriceTag(string name, double price)
        {
            return base.PriceTag(name, TotalPrice(price, CustomFee)) + " Custom fee: " + CustomFee.ToString();
        }
    }
}
