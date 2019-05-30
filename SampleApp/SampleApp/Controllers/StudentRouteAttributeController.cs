using SampleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    [RoutePrefix("student2")]
    public class StudentRouteAttributeController : Controller
    {
        private StudentRepository _repository = new StudentRepository();
        // GET: Student
        [Route("{name}")]
        [HttpGet]
        public ActionResult Index(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return View(_repository.GetAll());
            }
            return View("Single", _repository.GetOne(name));
        }

        // in a WebApi controller, naming a method Delete would implicitly make it respond to the DELETE verb at "/student2". 
        // With MVC5, you have to be more explicit in defining the route.
        [HttpDelete]
        [Route("{name}")] 
        public ActionResult Delete(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    return new HttpStatusCodeResult(200, $"Remaining students: {_repository.GetAll().Count()}");
                }
                // Ignoring error because the result returned for an empty/null name works, and this is just a sample app.
                catch
                { }
            }
            return new HttpStatusCodeResult(500, "Couldn't find the requested student to delete.");
        }
    }
}