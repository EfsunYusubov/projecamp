using Microsoft.AspNetCore.Mvc;
using ProjectCamp.Models;
using System.Collections.Generic;

namespace ProjectCamp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Semender"
                },
                new UserComment
                {
                     ID = 2,
                     Username = "Efsun"
                },
                new UserComment
                {
                     ID = 3,
                    Username = "Cimi"
                },
            };

            return View(commentvalues);
        }
    }
}
