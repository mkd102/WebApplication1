using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;
using WebApplication1.Security;
using WebApplication1.Service;

namespace WebApplication1.Controller
{
    [Route("/Home")]
    public class HomeController : ControllerBase
    {
        private IEmployeeService EmployeeService;
        public HomeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }
        // GET: HomeController
        //public ActionResult Index()
        //{
        //    return ViewResult();
        //}

        //// GET: HomeController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: HomeController/Create
        [Authorization]
        public ActionResult Create()
        {
            EmployeeService.AddEmployee();
            return null;
        }

        // POST: HomeController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HomeController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: HomeController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HomeController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: HomeController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //public ActionResult Testing()
        //{
        //    ViewData["vd"] = 1;
        //    return View();
        //}
    }
}
