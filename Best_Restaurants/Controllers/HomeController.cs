using Microsoft.AspNetCore.Mvc;

namespace Best_Restaurants.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}