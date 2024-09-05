using Company.Data.Models;
using Company.Service;
using Company.Service.Interfaces.Employee;
using Company.Service.Services.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_3__MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = _employeeService;
        }
        public IActionResult Index()
        {
            var employees = _employeeService.GetAll();

            return View(employees);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee );
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("employeetError", "validationErrors");
                return View(employee);
            }

            catch (Exception ex)
            {
                ModelState.AddModelError("employeeError", ex.Message);
                return View(employee);
            }
        }

        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var employee = _employeeService.GetById(id.Value);
            if (employee == null)
            {
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Edit(int? id)
        {

            return Details(id, "Update");
        }
        [HttpPost]
        public IActionResult Edit(int? id, Employee employee)
        {
            if (employee.Id == id.Value)
            {
                return RedirectToAction("Index");
            }
            _employeeService.Update(employee);
            return View(employee);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var employee = _employeeService.GetById(id.Value);
            if (employee == null)
            {
                return RedirectToAction("Index");
            }

            return View(employee);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return RedirectToAction("Index");
            }

            _employeeService.Delete(employee);
            return RedirectToAction("Index");
        }
    }


}



