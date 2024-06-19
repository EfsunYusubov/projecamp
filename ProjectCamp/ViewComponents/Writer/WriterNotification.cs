﻿using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCamp.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {

        NotificationManager nm = new NotificationManager(new EFNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }

    }

}