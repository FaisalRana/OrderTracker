using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Price  { get; set; }
    public bool Available  { get; set; }
    private static List<Order> orderList_ = new List<Order>();

  public Order(string description, int price, bool available)
    {
      Description = description;
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
