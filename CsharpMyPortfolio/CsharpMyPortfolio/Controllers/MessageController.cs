using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpMyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult changeIsReadToTrue(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult changeIsReadToFalse(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult MessageDetail(int id)
        {
            var values = context.Messages.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return View(values);
        }

    }
}

