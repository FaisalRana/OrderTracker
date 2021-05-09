using System.Collections.Generic;


namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price  { get; set; }
    public string Date  { get; set; }
    public int Id { get; set;}
    private static List<Order> _orderList = new List<Order>();

  public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = _orderList.Count;
      _orderList.Add(this);
    }

  public static List<Order> GetAll()
    {
      return _orderList;
    }
    public static Order Find(int searchId)
    {
      return _orderList[searchId-1];
    }
  }
}
