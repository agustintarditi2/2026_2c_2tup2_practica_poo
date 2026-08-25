using Microsoft.AspNetCore.Mvc;
using practica1.Ej3;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpPost("person")]
    public string CreatePerson(string name)
    {
        Person person = new Person(name);

        return person.Greet();
    }

    [HttpPost("student")]
    public IActionResult CreateStudent(string name, int age)
    {
        Student student = new Student(name);

        student.SetAge(age);

        return Ok(new
        {
            Greeting = student.Greet(),
            Age = student.ShowAge()
        });
    }

    [HttpPost("teacher")]
    public IActionResult CreateTeacher(string name, int age)
    {
        Teacher teacher = new Teacher(name);

        teacher.SetAge(age);

        return Ok(new
        {
            Greeting = teacher.Greet(),
            Explanation = teacher.Explain()
        });
    }
}