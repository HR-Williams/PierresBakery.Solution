using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    // public string Description { get; }

      public int Price { get; }

      public Bread(int price) 
    {
      Price = 5;
      _instances.Add(this);
    }

    private static List<Bread> _instances = new List<Bread> {};
    public static List<Bread> GetAll()
    {
    return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}