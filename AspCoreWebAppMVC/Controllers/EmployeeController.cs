using AspCoreWebAppMVC.Data;
using AspCoreWebAppMVC.Models;
using AspCoreWebAppMVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public EmployeeController(ApplicationDBContext db)
        {
            _dbContext = db;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var dbcontext = _dbContext.Employees.ToList();
            return View(dbcontext);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employee req = new Employee{
                        
                        Name = model.Name,
                        Email = model.Email,
                    };
                    _dbContext.Employees.Add(req);
                    _dbContext.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
