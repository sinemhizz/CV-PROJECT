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
	public class FeatureManager : IGenericService<Feature>
	{
		IFeatureRepository _featureRepository;

		public FeatureManager(IFeatureRepository featureRepository)
		{
			_featureRepository = featureRepository;
		}

		public void TAdd(Feature t)
		{
			_featureRepository.Insert(t);
		}

		public void TDelete(Feature t)
		{
			_featureRepository.Delete(t);
		}

		public Feature TGetById(int id)
		{
			return _featureRepository.GetByID(id);
		}

		public List<Feature> TGetList()
		{
			return _featureRepository.GetList();
		}

		public void TUpdate(Feature t)
		{
			_featureRepository.Update(t);
		}
	}
}
