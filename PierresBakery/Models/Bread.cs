using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    // public string Description { get; }
    private static List<Bread> _instances = new List<Bread> {};
    public static List<Bread> GetAll()
    {
    return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    // public Bread(string description)
    // {
    //   Description = description;
    //   _instances.Add(this);
      
    // }
  }
}