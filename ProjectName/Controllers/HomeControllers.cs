using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() {return "Hello friend!"; }

    [Route("/")]
    public ActionResult Project() 
    {
      ProjectVariable myProjectVariable = new ProjectVariable();
      myProjectVariable.Verb = "Runs";
      return View(myProjectVariable); 
    }

  }
}

