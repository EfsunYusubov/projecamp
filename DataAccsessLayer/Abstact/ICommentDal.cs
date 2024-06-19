using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstact
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        List<Comment> GetListWithBlog();
    }
}
