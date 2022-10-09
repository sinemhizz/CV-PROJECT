using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.Controllers
{
	public class SkillController : Controller
	{
		SkillManager skillManager = new SkillManager(new EFSkillRepository());
		public IActionResult Index()
		{
			var values = skillManager.TGetList();
			return View(values);
		}
	}
}
