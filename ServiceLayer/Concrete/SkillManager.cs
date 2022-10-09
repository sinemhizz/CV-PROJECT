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
	public class SkillManager : ISkillService
	{
		ISkillRepository _skillRepository;

		public SkillManager(ISkillRepository skillRepository)
		{
			_skillRepository = skillRepository;
		}

		public void TAdd(Skill t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Skill t)
		{
			throw new NotImplementedException();
		}

		public Skill TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Skill> TGetList()
		{
			return _skillRepository.GetList();
		}

		public void TUpdate(Skill t)
		{
			throw new NotImplementedException();
		}
	}
}
