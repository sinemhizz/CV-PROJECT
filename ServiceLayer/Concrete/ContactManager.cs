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
	public class ContactManager : IContactService
	{
		IContactRepository _contactRepository;

		public ContactManager(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public void TAdd(Contact t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Contact t)
		{
			throw new NotImplementedException();
		}

		public Contact TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			return _contactRepository.GetList();
		}

		public void TUpdate(Contact t)
		{
			throw new NotImplementedException();
		}
	}
}
