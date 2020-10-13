using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees=Employee.GetEmployees();
        
        return View(employees);
    }
    public ActionResult Details(string firstName)
    {
        var employees = Employee.GetEmployees();
        // var employee = employees.Where(x => x.FirstName == firstName).First();
        // var employee = employees.First(x => x.FirstName == firstName);
        var employee = employees.FirstOrDefault(x => x.FirstName == firstName);


        return View(employees);
        return View(employee);
    }
}