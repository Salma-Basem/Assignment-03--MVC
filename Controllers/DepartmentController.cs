﻿using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Service;
using Company.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;



namespace Assignment_3__MVC.Controllers
{

    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var departments = _departmentService.GetAll();

            return View(departments);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost] 
        public IActionResult Create(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _departmentService.Add(department);
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("DepartmentError", "validationErrors");
                return View(department);
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(department);
            }
        }

        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var department = _departmentService.GetById(id.Value);
            if (department == null)
            {
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public IActionResult Edit(int? id)
        {

            return Details(id, "Update");
        }
        [HttpPost]
        public IActionResult Edit(int? id, Department department)
        {
            if (department.Id == id.Value)
            {
                return RedirectToAction("Index");
            }
            _departmentService.Update(department);
            return View(department);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var department = _departmentService.GetById(id.Value);
            if (department == null)
            {
                return RedirectToAction("Index");
            }

            return View(department);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var department = _departmentService.GetById(id);
            if (department == null)
            {
                return RedirectToAction("Index");
            }

            _departmentService.Delete(department);
            return RedirectToAction("Index");
        }
    }


}




