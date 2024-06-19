using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjectCamp.ViewComponents.Writer
{
     
    public class WriterAboutOnDashboard: ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EFWriterRepository());
       
        Context c = new Context();  
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;            
            // Uyğun Maile göre detayları getirir.
            ViewBag.veri = username;
            var usermail = c.Users.Where(x=>x.UserName==username).Select(y=>y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail)
                .Select(y => y.WriterID).FirstOrDefault();

            var values = writermanager.GetWriterById(writerID);
            return View(values);
        }
    }
}
