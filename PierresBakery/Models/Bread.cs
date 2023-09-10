using System.Collections.Generic;

namespace PierresBakery.Models
{
    public partial class Bread
    {
        public int Quantity { get; set; }

        public Bread(int quantity)
        {
            Quantity = quantity;
        }

        public decimal CalculateTotalPrice()
        {
            int fullPriceItems = Quantity / 2;
            int freeItems = Quantity % 2;
            return (fullPriceItems + freeItems) * 5;
        }
    }
}
