﻿using BusinessLayer.Abstact;
using DataAccsessLayer.Abstact;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment Comment)
        {
            _commentdal.Insert(Comment);
        }

        public List<Comment> GetCommentWithBlog()
        {
            return _commentdal.GetListWithBlog();
        }

        public List<Comment> GetList(int id)
        {
            return _commentdal.GetListAll(x => x.BlogID == id);
        }
    }
}