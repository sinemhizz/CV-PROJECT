using EntityLayer.Concrete;
using RepositoryLayer.Abstract;
using ServiceLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Concrete
{
	public class TestimonialsManager : ITestimonialService
	{
		ITestimonialRepository _testimonialRepository;

		public TestimonialsManager(ITestimonialRepository testimonialRepository)
		{
			_testimonialRepository = testimonialRepository;
		}

		public void TAdd(Testimonial t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Testimonial t)
		{
			throw new NotImplementedException();
		}

		public Testimonial TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Testimonial> TGetList()
		{
			return _testimonialRepository.GetList();
		}

		public void TUpdate(Testimonial t)
		{
			throw new NotImplementedException();
		}
	}
}
