using System;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents
{
	public class _PortfolioComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

