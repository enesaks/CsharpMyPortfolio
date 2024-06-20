using System;
namespace CsharpMyPortfolio.DAL.Entities
{
	public class Portfolio
	{
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string SubTtitle { get; set; }
        public string ImagrUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

    }
}

