using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpMyPortfolio.DAL.Context;
using CsharpMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CsharpMyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList todo)
        {
            todo.Status = false;
            todo.Date = DateTime.SpecifyKind(todo.Date, DateTimeKind.Utc);
            context.ToDoLists.Add(todo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList todo)
        {
            todo.Date = DateTime.SpecifyKind(todo.Date, DateTimeKind.Utc);
            context.ToDoLists.Update(todo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult changeIsReadToTrue(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult changeIsReadToFalse(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

