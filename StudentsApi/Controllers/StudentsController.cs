using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{
    private readonly StudentContext db;
    public StudentController(StudentContext _db){
        db=_db;
    }
    [HttpGet]
    [Route("all")]
    public ActionResult getAllStudents()
    {
        

        var students = db.Students.ToList();
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
