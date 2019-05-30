using SampleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository _repository = new StudentRepository();
        // GET: Student
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