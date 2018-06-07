using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityStudent.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EntityStudent.Models;

namespace EntityStudent.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (var StuContext = new ContextStudent())
            {
                var StudentsList = new List<ModelStudent>();
                StudentsList = StuContext.TableStudent.ToList();
                return Ok(StudentsList);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]ModelStudent StudentObject)
        {
            using (var StuContext = new ContextStudent())
            {
                StuContext.TableStudent.Add(StudentObject);
                StuContext.SaveChanges();
            }
            return Ok("StudentAdded");
        }

        [HttpPut]
        public ActionResult Put([FromBody]ModelStudent StudentObject)
        {
            using (var StuContext = new ContextStudent())
            {
                StuContext.TableStudent.Update(StudentObject);
                StuContext.SaveChanges();
            }
            return Ok("StudentUpdated");
        }

        [HttpDelete]
        public ActionResult Delete([FromBody]ModelStudent StudentObject)
        {
            using (var StuContext = new ContextStudent())
            {
                StuContext.TableStudent.Remove(StudentObject);
                StuContext.SaveChanges();
            }
            return Ok("StudentDeleted");
        }
    }
}