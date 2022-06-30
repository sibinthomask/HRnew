using HRnew.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRnew.Controllers
{
    public class HRController : Controller
    {
        string viewPage = "";
        KTserv_HRContext dbContext = new KTserv_HRContext();
        // GET: HRController
        public ActionResult HRlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HRlogin(IFormCollection fc)
        {
            var q = from p in dbContext.EmployeeRegistrations
                    where p.EmpUsername == fc["EmpUsername"].ToString()
                    && p.EmpPassword == fc["EmpPassword"].ToString()
                    select p;

            if (q.Any())
            {
                viewPage = "Dashboard";
            }
            else
            {
                viewPage = "HRlogin";
            }
            return View(viewPage);
        }


        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dashboard(HrDashboard dbName)
        {
            viewPage = dbName.DashboardName.ToString();
            if (dbName.DashboardName == "HR_Employee:Dashboard")
            {
                viewPage = "Dashboard";
                return RedirectToAction(viewPage, "HR_Employee");
            }
            return View(viewPage);
        }

        [HttpGet]
        public ActionResult Designation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Designation(HrDesignation designation)
        {
            if (dbContext.HrDesignations.Count((a) => a.Designation == designation.Designation) == 0)
            {
                HrDesignation desig = new HrDesignation();

                desig.Designation = designation.Designation;
                desig.DutiesAssigned = designation.DutiesAssigned;

                dbContext.HrDesignations.Add(desig);
                dbContext.SaveChanges();

                viewPage = "Designation";
            }
            return View(viewPage);
        }
        [HttpGet]
        public ActionResult OnlineSalaryTransaction()
        {
            return View();
        }



        // POST: HRController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: HRController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HRController/Edit/5
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

        // GET: HRController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HRController/Delete/5
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
