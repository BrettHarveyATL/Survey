using Microsoft.AspNetCore.Mvc;
using System;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("submit")]
        public IActionResult Submit(Survey newSurvey)
        {
            
            return View("Results", newSurvey);
        }
    }
}