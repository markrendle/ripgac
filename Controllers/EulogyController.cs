using Microsoft.AspNet.Mvc;

public class EulogyController
{
  private readonly IActionResultHelper _result;
  public EulogyController(IActionResultHelper result)
  {
    _result = result;
  }
  public ActionResult Index()
  {
    return _result.View("Index", null);
  }
}