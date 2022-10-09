using EntityLayer.Concrete;
using RepositoryLayer.Abstract;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.EntityFramework
{
	public class EFAboutRepository : GenericRepository<About> , IAboutRepository
	{
	}
}
