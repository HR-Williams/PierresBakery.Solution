using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
      public int BreadPrice { get; set; } = 5;
      public int BreadQuantity {get; set;}

      public Bread(int breadQuantity) 
      {
      BreadQuantity = breadQuantity;
      // Price = 5;
      }

    public int TotalBreadPrice()
    {
      int totalBreadPrice = BreadQuantity * BreadPrice;
      return totalBreadPrice;
    //   //seeing if there are three or more
    //   //calculating quantity + price
    //   //return total price  
    }
  }
}