using System;
using Microsoft.AspNetCore.Mvc;
using CsharpMyPortfolio.DAL.Context;

namespace CsharpMyPortfolio.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Features.ToList();
			return View(values);
		}
	}
}

