using System;
using Microsoft.AspNetCore.Mvc;

namespace CsharpMyPortfolio.ViewComponents
{
	public class _TestimonialComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

