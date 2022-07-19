using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpPost("/index")]
    public ActionResult Create(int height, int width, int length, int weight) 
    {
      ParcelVariable newParcel = new ParcelVariable(height, width, length, weight);
      newParcel.Height = height;
      return RedirectToAction("Index"); 
    }

    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View("index");
    }

    // [Route("/")]
    // public ActionResult Project() 
    // {
    //   // ProjectVariable myProjectVariable = new ProjectVariable();
    //   // myProjectVariable.Verb = "Runs";
    //   // return View(myProjectVariable); 
    // }

  }
}

