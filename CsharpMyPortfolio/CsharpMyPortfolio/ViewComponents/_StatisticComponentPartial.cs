using System;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents
{
	public class _StatisticComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

