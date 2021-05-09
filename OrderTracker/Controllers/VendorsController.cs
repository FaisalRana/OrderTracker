using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> newList = Vendor.GetAll();
      return View(newList);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription, string vendorLocation)
    {
    Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorLocation);
    return RedirectToAction("Index");
    }
    
    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int id) 
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> VendorOrders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", VendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{VendorId}/Orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> VendorOrders = foundVendor.Orders;
      model.Add("Orders", VendorOrders);
      model.Add("Vendor", foundVendor);
      return View("Show", model);
    }

  }
} 