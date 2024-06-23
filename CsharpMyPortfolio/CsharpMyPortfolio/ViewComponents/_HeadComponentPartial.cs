using System;
using Microsoft.AspNetCore.Mvc;
namespace CsharpMyPortfolio.ViewComponents
{
	public class _HeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

