using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    // public string Description { get; }
    public int Price { get; }
    public Pastry(int price) 
    {
      Price = 2;
      _instances.Add(this);
    }

    private static List<Pastry> _instances = new List<Pastry> {};

    public static List<Pastry> GetAll()
    {
    return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
  }
}