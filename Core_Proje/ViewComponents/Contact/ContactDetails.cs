using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
		ContactManager contactManager = new ContactManager(new EFContactRepository());
		public IViewComponentResult Invoke()
		{
			var values = contactManager.TGetList();
			return View(values);
		}
	}
}
