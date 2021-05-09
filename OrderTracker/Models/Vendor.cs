using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public string Location { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string description, string location)
    {
      Name = vendorName;
      Description = description;
      Location = location;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }
      public static List<Vendor> GetAll()
    {
      return _instances;
    }

  }
}