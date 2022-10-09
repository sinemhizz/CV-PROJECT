using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Portfolio
{
	public class PortfolioList : ViewComponent
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioRepository());
		public IViewComponentResult Invoke()
		{
			var values = portfolioManager.TGetList();
			return View(values);
		}
	}
}
