using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public string Description { get; }

    private static List<Pastry> _instances = new List<Pastry> {};

    public static List<Pastry> GetAll()
    {
    return _instances;
    }
    public Pastry(string description)
    {
      Description = description;
      _instances.Add(this);
    }
  }
}