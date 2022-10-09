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
	public class ServiceManager : IServiceService
	{
		IServiceRepository _serviceRepository;

		public ServiceManager(IServiceRepository serviceRepository)
		{
			_serviceRepository = serviceRepository;
		}

		public void TAdd(Service t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Service t)
		{
			throw new NotImplementedException();
		}

		public Service TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Service> TGetList()
		{
			return _serviceRepository.GetList();
		}

		public void TUpdate(Service t)
		{
			throw new NotImplementedException();
		}
	}
}
