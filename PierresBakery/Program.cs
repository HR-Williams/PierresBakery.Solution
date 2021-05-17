using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery {
  public class Program
  {
    public static void Main()
    {
      
      Console.WriteLine("Welcome to Pierre's Bakery :)");
      Console.WriteLine("Menu:");
      Console.WriteLine("Bread: 1 loaf for $5. Or our special deal--buy 2 get 1 free (3 for $10)");
      Console.WriteLine("Pastries: 1 pastry for $2. Or our special deal--3 for $5");
      Console.WriteLine("Enter number of loaves of bread you would like to order: ");
      string stringBreadQuantity = Console.ReadLine();
      int breadQuantity = int.Parse(stringBreadQuantity);
      Console.WriteLine("Enter number of pastries you would like to order ");
      string stringPastryQuantity = Console.ReadLine();
      int pastryQuantity = int.Parse(stringPastryQuantity);
      Bread orderBread = new Bread(breadQuantity);
      Pastry orderPastry = new Pastry(pastryQuantity);
      int totalBill = orderBread.TotalBreadPrice() + orderPastry.TotalPastryPrice();
      Console.WriteLine("Your order comes to: $" + totalBill);
    }

    }
  }  
