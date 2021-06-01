using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
namespace WebApplication3.ViewComponents
{
    public class Navigation:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (var db = new HotelWebContext())
            {
                var settings = db.Settings.Where(z => z.SettingsId == 1).ToList();

                return View(settings);
            }
        }


    }
}
