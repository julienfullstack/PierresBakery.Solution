using System;
using PierresBakery.Models;


namespace PierresBakery.Models
{
  public class Program
  {
      public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("We have two items for sale today:");
            Console.WriteLine("Bread: $5 each or buy 2, get 1 free!");
            Console.WriteLine("Pastry: $2 each or 3 for $5!");
            Console.WriteLine("How many loaves of bread would you like?");
            string breadInput = Console.ReadLine();
            int breadQuantity = int.Parse(breadInput);
            Bread bread = new Bread(breadQuantity);
            Console.WriteLine("How many pastries would you like?");
            string pastryInput = Console.ReadLine();
            int pastryQuantity = int.Parse(pastryInput);
            Pastry pastry = new Pastry(pastryQuantity);
            Console.WriteLine("Thank you for your order!");
            Console.WriteLine("You ordered " + bread.Quantity + " loaves of bread and " + pastry.Quantity + " pastries.");
            Console.WriteLine("Your total quantity is " + bread.CalculateTotalQuantity() + " loaves of bread and " + pastry.CalculateTotalQuantity() + " pastries.");
            Console.WriteLine("Your total is $" + bread.CalculateTotalPrice() + " for bread and $" + pastry.CalculateTotalPrice() + " for pastries.");
            Console.WriteLine("Your grand total is $" + (bread.CalculateTotalPrice() + pastry.CalculateTotalPrice()) + ".");
        }
      }
  }
