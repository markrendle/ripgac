using Microsoft.AspNet.Mvc;
using System.Reflection;

// I've inherited from Controller here because I want ViewBag.
// I could probably get it injected like IActionResultHelper, but I'm lazy.
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