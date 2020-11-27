using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Employee
{
    [Required (EttorMessage="FirstNmae required")]
    [Display(Name ="First Name")]
     [Required]
    public string FirstName { get; set; }
    [Required]
     [Required(ErrorMessage= "Lastname required")]
    [Display(Name ="Last Name")]
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        // Object initializer
        var employee1 = new Employee { FirstName = "Top", Surname = "Shrestha", Address = "Ktm", Salary = 10500.0 };
        var employee2 = new Employee { FirstName = "Shyam", Surname = "Basnet", Address = "Bhaktapur", Salary = 105000.0 };
        var employee3 = new Employee { FirstName = "Bijay", Surname = "Nepal", Address = "Dang", Salary = 9000.0 };
        var employee4 = new Employee { FirstName = "Pritam", Surname = "Khatri", Address = "Chitwan", Salary = 11100.0 };
        var employee5 = new Employee { FirstName = "NiKhil", Surname = "Uppreti", Address = "Lalitpur", Salary = 8500.0 };
        var employee6 = new Employee { FirstName = "Binay", Surname = "Bajracharya", Address = "Ktm", Salary = 26000.0 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;     
    }
}