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
        public ActionResult Index(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return View(_repository.GetAll());
            }
            return View("Single", _repository.GetOne(name));
        }
    }
}