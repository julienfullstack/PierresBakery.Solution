using System.Collections.Generic;

namespace PierresBakery.Models
{
  public partial class Pastry
  {
      public int Quantity { get; set; }

      public Pastry(int quantity)
      {
          Quantity = quantity;
      }

       public decimal CalculateTotalPrice()
        {
            int setsOfFour = Quantity / 4; 
            int remainingPastries = Quantity % 4; 
            decimal totalPrice = setsOfFour * 3 * 2;
            totalPrice += remainingPastries * 2; 

            return totalPrice;
        }
    }
}
