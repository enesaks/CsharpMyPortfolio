using System;
using CsharpMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents
{
	public class _AboutComponentPartial : ViewComponent
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
		{
			ViewBag.title = context.Abouts.Select(x => x.Title).FirstOrDefault();
			ViewBag.subDescription = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
			ViewBag.details = context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
		}
	}
}

