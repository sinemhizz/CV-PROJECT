using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{
		SkillManager skillManager = new SkillManager(new EFSkillRepository());
		public IViewComponentResult Invoke()
		{
			var values = skillManager.TGetList();
			return View(values);	
		}
	}
}
