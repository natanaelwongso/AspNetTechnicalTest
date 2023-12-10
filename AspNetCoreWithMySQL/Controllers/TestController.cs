using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TestTechnical.Models;

namespace TestTechnical.Controllers
{
    public class TestController : Controller
    {
        public List<test_schedule_tbl> DataSchedule;
        public IActionResult Index()
        {
            DataSchedule = new List<test_schedule_tbl>();
            DataSchedule.Add(new test_schedule_tbl()
            {
                ID = 1,
                Category = "ABC",
                Title = "Title123",
                Description = "Test123",
                Location = "http:/google.com",
                TestDate = DateTime.Now
            });
            return View(DataSchedule);
        }


        [HttpPost]
        public IActionResult Search()
        {
            return Json(new { message = "Action executed successfully" });
        }
    }
}
