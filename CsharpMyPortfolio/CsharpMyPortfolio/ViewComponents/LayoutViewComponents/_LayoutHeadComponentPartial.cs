using System;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

