using Microsoft.AspNet.Mvc;
using System.Reflection;

public class AboutController : Controller
{
  public ActionResult Index()
  {
    var asm = Assembly.Load(new AssemblyName("klr.host"));
    var version = asm.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
    ViewBag.KlrVersion = version.InformationalVersion;
    return View();
  }
}