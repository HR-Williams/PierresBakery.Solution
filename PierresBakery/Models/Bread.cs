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
      }

    public int TotalBreadPrice()
    {
      if (BreadQuantity % 3 == 0)
      {
      int totalBreadPrice = (BreadQuantity - (BreadQuantity / 3)) * BreadPrice;
      return totalBreadPrice;
      }
      else
      {
        return BreadPrice * BreadQuantity;
      }

    }
  }
}