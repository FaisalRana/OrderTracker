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

  }
}