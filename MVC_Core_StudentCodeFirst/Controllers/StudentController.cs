using Microsoft.AspNetCore.Mvc;
using StudentRepository.Abstract;
using StudentRepository.Repository;
using StudentRepository.Models;
namespace MVC_Core_StudentCodeFirst.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepo IStudent = new StudentRepo();
        public IActionResult Index()
        {
            List<Student> lst= IStudent.GetAllStudentData();
            return View(lst);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            string msg= IStudent.Insert_Student(s);
            if (msg=="success")
                return RedirectToAction("Index");

            return View();
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            Student s = IStudent.GetStudentdetailOnSid(Convert.ToInt32(id));
            return View(s);
        }
        [HttpPost]
        public IActionResult Edit(Student s) 
        {
         string msg=IStudent.Update_Student(s);
            if (msg == "success")
                return RedirectToAction("Index");
            else
                ViewBag.Info = "Data not saved,try again latter";
            return View();
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            string msg = IStudent.Delete_Student(Convert.ToInt32(id));
            if (msg=="success")
                return RedirectToAction("Index");

         return View();
        }
    }
}
