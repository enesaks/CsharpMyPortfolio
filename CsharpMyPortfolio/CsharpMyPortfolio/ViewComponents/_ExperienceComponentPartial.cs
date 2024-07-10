using System;
using CsharpMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents
{
	public class _ExperienceComponentPartial : ViewComponent
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
		{
			var values = context.Experiences.ToList();
			return View(values);
		}
	}
}

