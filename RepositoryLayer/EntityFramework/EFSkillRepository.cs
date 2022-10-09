using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using RepositoryLayer.Abstract;
using RepositoryLayer.Repository;

namespace RepositoryLayer.EntityFramework
{
	public class EFSkillRepository:GenericRepository<Skill>,ISkillRepository
	{
	}
}
