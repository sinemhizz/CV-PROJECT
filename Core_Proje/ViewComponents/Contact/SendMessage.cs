using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;
using System;

namespace Core_Proje.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		MessageManager messageManager = new MessageManager(new EFMessageRepository());

		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
		//[HttpPost]
		//public IViewComponentResult Invoke(Message p)
		//{
		//	p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
		//	p.Status = true;
		//	messageManager.TAdd(p);
		//	return View();
		//}
	}
}
