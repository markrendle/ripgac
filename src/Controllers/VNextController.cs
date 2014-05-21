using Microsoft.AspNet.Mvc;

public class VNextController
{
  private readonly IActionResultHelper _result;
  public VNextController(IActionResultHelper result)
  {
    _result = result;
  }

  public ActionResult Index()
  {
    return _result.View("Index", null);
  }

  public ActionResult Resources()
  {
    return _result.View("Resources", null);
  }
}