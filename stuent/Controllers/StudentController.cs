using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace stuent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        public static List<Student> students = new List<Student>
    {
      new Student
    {
      id = 1,
      firstName = "John",
      lastname = "Doe",
      address = "123 Main St",
      phone = "555-1234",
      active = false,
     // mail = "chayale96@gmail.com",
      avgMark = 90,
      test = new List<Test>()
      {
         new Test
        {
          nameOfTest = "English",mark = 100, kode = 1,date = new DateTime(2023,10,23)
        },
          new Test
        {
          nameOfTest = "English",mark = 100, kode = 1,date = new DateTime(2023,10,23)
        },
          new Test
        {
          nameOfTest = "English",mark = 100, kode = 1,date = new DateTime(2023,10,23)
        },
      },
      //absenceDays = new List<AbsenceDay>()
    },
      new Student
    {
      id = 2,
      firstName = "Jane",
      lastname = "Smith",
      address = "456 Elm St",
      phone = "555-5678",
      active = false,
     // mail = "chayale96@gmail.com",
      avgMark = 85,
      test = new List<Test>()
      {
         new Test
        {
          nameOfTest = "English",mark = 100, kode = 1,date = new DateTime(2023,10,23)
        },
          new Test
        {
          nameOfTest = "English",mark = 100, kode = 1,date = new DateTime(2023,10,23)
        },
          new Test
        {
          nameOfTest = "English",mark = 100, kode = 1,date = new DateTime(2023,10,23)
        },
      },
      //absenceDays = new List<AbsenceDay>()
    },
      new Student
    {
      id = 3,
      firstName = "Alex",
      lastname = "Johnson",
      address = "456 Elm St",
      phone = "555-5678",
      active = true,
      avgMark = 85,
      school_year=(Year)1
    }
    };


        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentsController>/5

        [HttpGet("{active}")]
        public IEnumerable<Student> Get(bool active)
        {
            return active ? students.Where(x => x.active) : students;
        }

        [HttpPost]
        public void Post([FromBody] Student student)
        {
            students.Add(student);
        }

        //to update an object
        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            Student studentToUpdate = students.Where(s => s.id == id).FirstOrDefault();
            if (studentToUpdate != null)
            {
                int index = students.FindIndex(s => s.id == id);
                students[index] = student;
            }
            else
            {
                students.Add(student);
            }
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = students.FindIndex(s => s.id == id);
            if (index < 0)
                return;
            students.Remove(students[index]);
        }
    }
}
