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

        public decimal CalculateTotalQuantity(){
            int freeLoaves = Quantity / 2;
            int totalQuantity = Quantity + freeLoaves;
            return totalQuantity;
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