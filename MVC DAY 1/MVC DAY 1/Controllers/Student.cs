using Microsoft.AspNetCore.Mvc;
using MVC_DAY_1.Models;
using System.Web.Helpers;


namespace MVC_DAY_1.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext DB;

        public StudentController()
        {
            DB = new();
        }



        public IActionResult Create()
        {
            ViewBag.ErrorMessage = null;

            ViewBag.Classes = DB.Classes.ToList();

            return View();
        }

        public IActionResult saveADD(string name, int age, string email, string address, int ClassID)
        {
            // validation
            if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                ViewBag.ErrorMessage = "All fields are required and age must be greater than 0.";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Create");
            }

            // Create student with ClassID
            DB.S.Add(new Models.Student
            {
                name = name,
                age = age,
                email = email,
                address = address,
                ClassID = ClassID
            });
            DB.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

        public IActionResult Edit(int Id)
        {
            try
            {
                var result = DB.S.Where(x => x.ID == Id).FirstOrDefault();
                if (result == null)
                {
                    ViewBag.ErrorMessage = "Student Not Found :(";
                    return View();
                }

                
                ViewBag.Classes = DB.Classes.ToList();

                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.Notfound = ex.Message;
                return View();
            }
        }

        public IActionResult updateStudent(Student s)
        {
            // validation
            if (string.IsNullOrEmpty(s.name))
            {
                ViewBag.ValidateMessage = "Name is required.";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Edit", s);
            }
            else if (s.age <= 0)
            {
                ViewBag.ValidateMessage = "Age must be greater than 0.";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Edit", s);
            }
            else if (string.IsNullOrEmpty(s.email))
            {
                ViewBag.ValidateMessage = "Email is required.";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Edit", s);
            }
            else if (string.IsNullOrEmpty(s.address))
            {
                ViewBag.ValidateMessage = "Address is required.";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Edit", s);
            }

            var student = DB.S.Where(x => x.ID == s.ID).FirstOrDefault();
            if (student == null)
            {
                ViewBag.ErrorMessage = "Student Not Found :(";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Edit", s);
            }

            student.name = s.name;
            student.age = s.age;
            student.email = s.email;
            student.address = s.address;
            student.ClassID = s.ClassID;

            DB.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

        public IActionResult GetByID(int Id)
        {
            try
            {
                var result = DB.S.Where(x => x.ID == Id).FirstOrDefault();
                if (result == null)
                {
                    ViewBag.ErrorMessage = "Student Not Found :(";
                    return View();
                }

                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.Notfound = ex.Message;
                return View();
            }
        }
        public IActionResult Delete(int Id)
        {
            try
            {
                var result = DB.S.Where(x => x.ID == Id).FirstOrDefault();
                if (result == null)
                {
                    ViewBag.ErrorMessage = "Student Not Found :(";
                    return View("GetByID");
                }
                DB.S.Remove(result);
                DB.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            catch (Exception ex)
            {
                ViewBag.Notfound = ex.Message;
                return View("Index", "Student");
            }
        }
        public IActionResult Index()
        {
            var result = DB.S.ToList();
            return View(result);
        }
    }
}
