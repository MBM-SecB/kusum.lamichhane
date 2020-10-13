using System.Collections.Generic;
public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }
    public static List <Employee> GetEmployees()
    {
        // Object initializer
        var employee1 = new Employee { FirstName = "kusum", Surname = "lamichhane", Address = "Ktm", Salary = 100.0 };
        var employee2 = new Employee { FirstName = "unika", Surname = "chaulagain", Address = "Bhaktapur", Salary = 10000.0 };
        var employee3 = new Employee { FirstName = "hareram", Surname = "lamichhane", Address = "Ktm", Salary = 100.0 };
        var employee4 = new Employee { FirstName = "laxmi", Surname = "dhungana", Address = "Ktm", Salary = 100.0 };
        var employee5 = new Employee { FirstName = "hardik", Surname = "kami", Address = "Ktm", Salary = 100.0 };
        var employee6 = new Employee { FirstName = "bishnuu", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;
    }
}