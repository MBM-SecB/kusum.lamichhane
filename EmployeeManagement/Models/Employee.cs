using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Employee
{
    [Required (ErrorMessage="FirstNmae required")]
    [Display(Name ="First Name")]
    public string FirstName { get; set; }
     [Required (ErrorMessage= "Lastname required")]
    [Display(Name ="Last Name")]
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }


}