using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Feature
{
	public class FeatureList : ViewComponent
	{
		FeatureManager featureManager = new FeatureManager(new EFFeatureRepository());
		public IViewComponentResult Invoke()
		{
			var values = featureManager.TGetList();
			return View(values);
		}
	}
}
