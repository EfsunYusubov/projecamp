using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface ICommentService
    {
        void CommentAdd(Comment Comment);
        
        List<Comment> GetList(int id);
        List<Comment> GetCommentWithBlog();
    }
}
