using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CsharpMyPortfolio.DAL.Context;
using CsharpMyPortfolio.DAL.Entities;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpMyPortfolio.Controllers
{

    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        // GET: /<controller>/
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Exprience experience)
        {
            context.Experiences.Add(experience);
                context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = context.Experiences.Find(id);
            context.Experiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = context.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Exprience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

    }
}

