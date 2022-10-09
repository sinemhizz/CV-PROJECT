using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EntityFramework;
using ServiceLayer.Concrete;

namespace Core_Proje.ViewComponents.Testimonial
{
	public class TestimonialList : ViewComponent
	{
		TestimonialsManager testimonialsManager = new TestimonialsManager(new EFTestimonialRepository());
		public IViewComponentResult Invoke()
		{
			var values = testimonialsManager.TGetList();
			return View(values);
		}
	}
}
