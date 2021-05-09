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
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }
  }
}