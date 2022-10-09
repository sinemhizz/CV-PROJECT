using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.About
{
	public class AboutList : ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EFAboutRepository());
		public IViewComponentResult Invoke()
		{
			var values = aboutManager.TGetList();
			return View(values);
		}
	}
}
