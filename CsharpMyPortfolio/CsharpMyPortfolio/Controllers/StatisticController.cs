using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpMyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x=>x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x=>x.IsRead == true).Count();

            return View();
        }
    }
}

