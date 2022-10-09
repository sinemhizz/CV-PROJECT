using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
		ServiceManager serviceManager = new ServiceManager(new EFServiceRepository());
		public IViewComponentResult Invoke()
		{
			var values = serviceManager.TGetList();
			return View(values);
		}
	}
}
