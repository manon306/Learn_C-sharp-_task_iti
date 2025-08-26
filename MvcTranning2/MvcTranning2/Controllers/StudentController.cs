using Microsoft.AspNetCore.Mvc;
using MvcTranning2.Models;
using MvcTranning2.Models.DAL;
using System;

namespace MvcTranning2.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolDBContext DB;

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
        public IActionResult saveCreate(String name, int age ,string email, int ClassID)
        {
            if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(email))
            {
                ViewBag.ValidateMessage = "Invalid input. Please fill all fields correctly.";
                return View("Create");
            }
            Student newStudent = new Student
            {
                name = name,
                age = age,
                email = email,
                ClassID = ClassID
            };
            DB.Students.Add(newStudent);
            DB.SaveChanges();

            return RedirectToAction("Index","Student");
        }
        public IActionResult Edit(int id)
        {
            var result =DB.Students.Where(s => s.ID == id).FirstOrDefault();
            if (result == null)
            {
                return NotFound();
            }
            ViewBag.Classes = DB.Classes.ToList();
            return View(result);
        }
        public IActionResult saveEdit(int id, String name, int age, string email, int ClassID)
        {
            var student = DB.Students.Where(s => s.ID == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }
            if (string.IsNullOrEmpty(name) || age <= 0 || string.IsNullOrEmpty(email))
            {
                ViewBag.ValidateMessage = "Invalid input. Please fill all fields correctly.";
                ViewBag.Classes = DB.Classes.ToList();
                return View("Edit", student);
            }
            student.name = name;
            student.age = age;
            student.email = email;
            student.ClassID = ClassID;
            DB.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
        public IActionResult Delete(int id)
        {
            var student = DB.Students.Where(s => s.ID == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        public IActionResult saveDelete(int id)
        {
            var student = DB.Students.Where(s => s.ID == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }
            DB.Students.Remove(student);
            DB.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
