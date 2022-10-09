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
	public class PortfolioManager : IPortfolioService
	{
		IPortfolioRepository _portfolioRepository;

		public PortfolioManager(IPortfolioRepository portfolioRepository)
		{
			_portfolioRepository = portfolioRepository;
		}

		public void TAdd(Portfolio t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Portfolio t)
		{
			throw new NotImplementedException();
		}

		public Portfolio TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Portfolio> TGetList()
		{
			return _portfolioRepository.GetList();
		}

		public void TUpdate(Portfolio t)
		{
			throw new NotImplementedException();
		}
	}
}
