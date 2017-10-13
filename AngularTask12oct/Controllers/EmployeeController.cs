using AngularTask12oct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularTask12oct.Controllers
{
    public class EmployeeController : ApiController
    {
        StudentContext db = new StudentContext();

        // GET: api/Employee
        public IHttpActionResult Get()
        {
            var res = db.Employees.ToList();
            return Ok(res);
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public IHttpActionResult Post(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok("Ok");
        }

        // PUT: api/Employee/5

        public IHttpActionResult Put(Employee value)
        {
            var res = db.Employees.Find(value.Id);
            res.Email = value.Email;
            res.DOB = value.DOB;
            //res.Image = value.Image;        
            db.SaveChanges();
            return Ok("Ok");

        }

        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            var res = db.Employees.Find(id);
            db.Employees.Remove(res);
            db.SaveChanges();
            return Ok("ok");

        }
    }
}

