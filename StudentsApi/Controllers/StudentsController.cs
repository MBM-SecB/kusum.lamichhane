using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult getAllStudents()
    {
        var students = new string[] {"Kusum", "Utsav"};

        students = null;

        if(students == null)
        {
            return BadRequest();
        }

        return Ok(students);
    }
    
    [HttpGet]
    [Route("{name}")]
    public ActionResult getAllStudentsById(string name)
    {
        var students = new string[] {"Kusum", "Utsav"};
         var student= students.Where(x=> x==name).FirstOrDefault();

       

        if(student == null)
        {
            return BadRequest();
        }

        return Ok(student);


    }

    [HttpPost]
    [Route("add")]
    public ActionResult Createstudent(Student student)
    {    

        if(student == null)
        {
            return BadRequest();
        }

        return Ok(student);


    }






}
