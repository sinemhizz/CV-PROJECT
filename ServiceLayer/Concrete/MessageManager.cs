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
	public class MessageManager : IMessageService
	{
		IMessageRepository _messageRepository;

		public MessageManager(IMessageRepository messageRepository)
		{
			_messageRepository = messageRepository;
		}

		public void TAdd(Message t)
		{
			_messageRepository.Insert(t);
		}

		public void TDelete(Message t)
		{
			throw new NotImplementedException();
		}

		public Message TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Message> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Message t)
		{
			throw new NotImplementedException();
		}
	}
}
