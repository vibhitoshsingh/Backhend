using AngularTask12oct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace AngularTask12oct.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class HomeController : ApiController
    {
        StudentContext db = new StudentContext();
        // GET: api/Home
        public IHttpActionResult Get()
        {
            var res = db.Students.ToList();
            return Ok(res);
        }

        // POST: api/Home
        public IHttpActionResult Post(Student value)
        {
            db.Students.Add(value);
            db.SaveChanges();
            return Ok("Ok");
        }

        // PUT: api/Home/1
        public IHttpActionResult Put(Student value)
        {
            var res = db.Students.Find(value.Id);
            res.ChildFirstName = value.ChildFirstName;
            res.ChildLastName = value.ChildLastName;
            res.ChildGender = value.ChildGender;
            res.Address = value.Address;
            res.City = value.City;
            res.PostalCode = value.PostalCode;

            db.SaveChanges();
            return Ok("Ok");

        }

        // DELETE: api/Home/1
        public IHttpActionResult Delete(int id)
        {
            var res = db.Students.Find(id);
            db.Students.Remove(res);
            db.SaveChanges();
            return Ok("ok");

        }

    }
}
