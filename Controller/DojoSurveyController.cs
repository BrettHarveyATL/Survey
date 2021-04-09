using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult Submit(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Results");
        }
    }
}