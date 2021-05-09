using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price  { get; set; }
    public bool Available  { get; set; }
    private static List<Order> orderList_ = new List<Order>();

  public Order(string description, int price, bool available, string name)
    {
      Description = description;
      Name = name;
      Price = price;
      Available = available;
      orderList_.Add(this);
    }

  public static List<Order> GetAll()
    {
      return orderList_;
    }
  }
}
