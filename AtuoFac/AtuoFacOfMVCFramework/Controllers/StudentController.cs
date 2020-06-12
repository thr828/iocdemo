using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtuoFacOfMVCFramework.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository iStudentRepository)
        {
            _studentRepository = iStudentRepository;
        }
        // GET: Student
        public ActionResult Index()
        {
            var liStudents = _studentRepository.GetAll();
            return View(liStudents);
        }
    }
}