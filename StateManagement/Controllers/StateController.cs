using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController : Controller
{
    public ViewResult First()
    {
        var name = "Kusum Lamichhane";
        // CookieOptions
        Response.Cookies.Append("user", name);
      HttpContext.Session.SetString("address","ktm");
        return View();
    }
    [HttpGet]
    public ViewResult Second(string name, int age)
    {
        return View();
    }
    [HttpPost]
    public bool Second(string collegeName)
    {
        return true;
    }
}
