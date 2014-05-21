using Microsoft.AspNet.Mvc;

public class HomeController
{
  private readonly IActionResultHelper _result;
  public HomeController(IActionResultHelper result)
  {
    _result = result;
  }
  public ActionResult Index()
  {
    return _result.View("Index", null);
  }
}