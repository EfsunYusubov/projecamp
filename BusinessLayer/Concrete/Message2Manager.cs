using BusinessLayer.Abstact;
using DataAccsessLayer.Abstact;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _messagedal;

        public Message2Manager(IMessage2Dal messagedal)
        {
            _messagedal = messagedal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messagedal.GetListWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _messagedal.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            _messagedal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _messagedal.Delete(t);
        }

        public Message2 TGetById(int id)
        {
            return _messagedal.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
