using HRnew.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace HRnew.Controllers
{
    public class HR_EmployeeController : Controller
    {
        string viewPage = "";
        KTserv_HRContext dbContext = new KTserv_HRContext();



        // GET: HR_EmployeeController
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
            return RedirectToAction(viewPage, "HR_Employee");
            //return View(viewPage);
        }

        public ActionResult EmployeeRegistration()
        {
            return View();
        }

        #region EmployeeSalary Pages
        [HttpGet]
        public ActionResult EmployeeSalary()
        {
            var DepartmentList = (from product in dbContext.HrDepartments
                                  select new SelectListItem()
                                  {
                                      Text = product.Name,
                                      Value = product.DepartmentId.ToString(),
                                  }).ToList();
            DepartmentList.Insert(0, new SelectListItem()
            {
                Text = "-----Select Department-----",
                Value = string.Empty
            });
            ViewBag.DepartmentList = DepartmentList;

            var EmployeeList = (from product in dbContext.EmployeeRegistrations
                                select new SelectListItem()
                                {
                                    Text = product.EmpName,
                                    Value = product.EmployeeId.ToString(),
                                }).ToList();
            EmployeeList.Insert(0, new SelectListItem()
            {
                Text = "-----Select Employee-----",
                Value = string.Empty
            });
            ViewBag.EmployeeList = EmployeeList;


            Class_CommonFunctions objCmnFntns = new Class_CommonFunctions();
            ViewBag.SalaryStatusList = objCmnFntns.getSalaryStatus();


            viewPage = "EmployeeSalary";
            return View(viewPage);
        }
        [HttpPost]
        public ActionResult EmployeeSalary(EmployeeSalary reg)
        {
            EmployeeSalary empReg = new EmployeeSalary();

            //Record not present
            if (reg.DeptId != null && reg.EmpId != null)
            {
                empReg.EmpId = reg.EmpId;
                empReg.DeptId = reg.DeptId;
                empReg.MonthlyWorkingDays = reg.MonthlyWorkingDays;
                empReg.SalaryAmount = reg.SalaryAmount;
                empReg.SalaryStatus = reg.SalaryStatus;

                empReg.RegDate = DateTime.Now;
                empReg.RegBy = 1;
                empReg.ModifiedDate = DateTime.Now;
                empReg.ModifiledBy = 1;

                dbContext.EmployeeSalaries.Add(empReg);
                dbContext.SaveChanges();

                viewPage = "EmployeeSalaryList";
            }
            else
            {
                //Record is present
                viewPage = "EmployeeSalary";
            }
            return RedirectToAction(viewPage);
        }
        public JsonResult GetEmpByDepId(int id)
        {
            var EmployeeList = (from C in dbContext.EmployeeRegistrations
                                where C.DepartmentId.ToString() == id.ToString()
                                select new SelectListItem()
                                {
                                    Text = C.EmpName,
                                    Value = C.EmployeeId.ToString(),
                                }).ToList();
            ViewBag.EmployeeList = EmployeeList;
            return Json(EmployeeList);
        }
        public ActionResult MyAction(string country)
        {
            var EmployeeList = (from C in dbContext.EmployeeRegistrations
                                where C.DepartmentId.ToString() == country
                                select new SelectListItem()
                                {
                                    Text = C.EmpName,
                                    Value = C.EmployeeId.ToString(),
                                }).ToList();
            EmployeeList.Insert(0, new SelectListItem()
            {
                Text = "-----Select Employee-----",
                Value = string.Empty
            });
            ViewBag.EmployeeList = EmployeeList;

            viewPage = "MyAction";
            return View(viewPage);
        }

        [HttpGet]
        public ActionResult EmployeeSalaryList()
        {
            ViewBag.EmployeeSalList = from EmployeeSal in dbContext.EmployeeSalaries
                                          //where AdmAdvertisments.AdvtStatus == "Active"
                                          //order by AdmAdvertisments.Salary descending
                                      orderby EmployeeSal.EmpSalId descending
                                      select EmployeeSal;
            return View();
        }
        [HttpGet]
        public ActionResult EmployeeSalaryEdit(int id)
        {
            ViewBag.EmployeeSalaryByID = from EmployeeDetails in dbContext.EmployeeSalaries
                                         where EmployeeDetails.EmpSalId == id
                                         //order by AdmAdvertisments.Salary descending
                                         select EmployeeDetails;

            Class_CommonFunctions objCmnFntns = new Class_CommonFunctions();
            ViewBag.SalaryStatusList = objCmnFntns.getSalaryStatus();
            //ViewBag.SalaryStatusList = new SelectList(dbContext.EmployeeSalaries, "SalaryStatusId", "SalaryStatusText",id);
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeSalaryEdit(EmployeeSalary objEmpSal)
        {
            EmployeeSalary empSal = new EmployeeSalary();

            if (objEmpSal.EmpId != null)
            {
                empSal.DeptId = objEmpSal.DeptId;
                empSal.EmpId = objEmpSal.EmpId;
                empSal.MonthlyWorkingDays = objEmpSal.MonthlyWorkingDays;
                empSal.SalaryAmount = objEmpSal.SalaryAmount;
                empSal.SalaryStatus = objEmpSal.SalaryStatus;
                empSal.ModifiedDate = DateTime.Now;
                empSal.ModifiledBy = 1;

                dbContext.EmployeeSalaries.Add(empSal);
                dbContext.SaveChanges();

                viewPage = "EmployeeSalaryList";
            }
            else
            {
                viewPage = "EmployeeSalaryEdit";
            }
            return RedirectToAction(viewPage);
        }
        #endregion

        // GET: HR_EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HR_EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HR_EmployeeController/Create
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

        // GET: HR_EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HR_EmployeeController/Edit/5
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

        // GET: HR_EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HR_EmployeeController/Delete/5
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
