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
            int setsOfThree = Quantity / 3; 
            int remainingLoaves = Quantity % 3; 

            decimal totalPrice = setsOfThree * 2 * 5; 
            totalPrice += remainingLoaves * 5; 

            return totalPrice;
        }
    }
}