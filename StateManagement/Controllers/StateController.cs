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
        var userAddress = HttpContext.Session.GetString("address");

        //2.2 Temp data

    TempData["CollegeName"] = "mbm college";    
        return View();
    }
    [HttpPost]
    public bool Second(string collegeName)
    {
        return true;
    }
    public ViewResult Third()
    {
        var cName = TempData["collegeName"]; 
        byte value =67;

        ViewData["Name1"]= "abc from viewdata";
        ViewBag.Name ="kusum";
        return View(value);
    }
}
