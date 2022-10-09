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
	public class ExperienceManager : IExperienceService
	{
		IExperienceRepository _experinceRepository;

		public ExperienceManager(IExperienceRepository experinceRepository)
		{
			_experinceRepository = experinceRepository;
		}

		public void TAdd(Experience t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Experience t)
		{
			throw new NotImplementedException();
		}

		public Experience TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Experience> TGetList()
		{
			return _experinceRepository.GetList();
		}

		public void TUpdate(Experience t)
		{
			throw new NotImplementedException();
		}
	}
}
