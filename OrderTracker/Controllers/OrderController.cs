using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/backpacking")]
    public ActionResult Index()
    {
      // List<Order> newList = new List<Order>();
      // List<Order> backpackingCatalogue = Order.GetAll();

      List<Order> newList = Order.GetAll();
      return View(newList);
    }

  }
}