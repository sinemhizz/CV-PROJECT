using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Experience
{
	public class ExperienceList :ViewComponent
	{
		ExperienceManager experienceManager = new ExperienceManager(new EFExperienceRepository());
		public IViewComponentResult Invoke()
		{
			var values = experienceManager.TGetList();
			return View(values);
		}
	}
}
