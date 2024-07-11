using System;
using CsharpMyPortfolio.DAL.Context;
using CsharpMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
		{
			ViewBag.todoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
			return View(values);
		}
	}
}

