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
          int fullPriceItems = Quantity / 3 * 2;
          int extraItems = Quantity % 3;
          return (fullPriceItems + extraItems) * 2;
      }
  }
}