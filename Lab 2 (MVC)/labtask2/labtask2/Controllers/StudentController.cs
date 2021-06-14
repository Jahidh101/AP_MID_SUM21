using labtask2.Models;
using labtask2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labtask2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Database db = new Database();
            var students = db.Students.GetAll();
            return View(students);
        }

        public ActionResult Create()
        {
            Student p = new Student();
            return View(p);
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            //insert to db
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Edit(int id)
        {

            Database db = new Database();
            var s = db.Students.Get(id);

            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            //update to db
            Database db = new Database();
            if (s.ID == 1)
            {
                db.Students.Update(s);
            }
            return RedirectToAction("Index");
        }
    }
}