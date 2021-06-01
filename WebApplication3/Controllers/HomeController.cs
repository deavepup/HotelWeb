using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // Home /İndex
        public ActionResult Index()
        {
            var st = ST();
            var room = AllRooms();
            var mainmodel = new MainViewModel
            {
                settings = st.settings,
                rooms = room.rooms

            };
            return View(mainmodel);
        }
        
        public ActionResult Rooms(int id,int? otherID, int? typeID)
        {
            using (var db = new HotelWebContext())
            {
                if (HttpContext.Request.Query.Count != 0)
                {
                    otherID = Convert.ToInt32(HttpContext.Request.Query["capacity"].ToString());
                    typeID = Convert.ToInt32(HttpContext.Request.Query["type"].ToString());
                    var model = db.Rooms.Where(x => x.OtherTypeId == otherID || x.RoomTypeId == typeID ).Include(r => r.OtherType)
    .Include(r => r.RoomType)
    .Include(r => r.Status)
    .ToList();
                    var mainmodel = new MainViewModel
                    {
                        rooms = model,


                    };
                    return View(mainmodel);
                }
                else
                {
                    var model = AllRooms();


                    var mainmodel = new MainViewModel
                    {
                        rooms = model.rooms,


                    };

                    return View(mainmodel);
                }

            }


        }
        public ActionResult rv()
        {
            var x = new HotelWebContext();
            Reservation rs = new Reservation();
            Guest gs = new Guest();
            gs.FirstName = HttpContext.Request.Query["name"].ToString();
            gs.LastName = HttpContext.Request.Query["surName"].ToString();
            gs.Adress = HttpContext.Request.Query["address"].ToString();
            gs.Email = HttpContext.Request.Query["email"].ToString();
            gs.Phone = HttpContext.Request.Query["phone"].ToString();
            gs.City = HttpContext.Request.Query["city"].ToString();
            gs.Country = HttpContext.Request.Query["country"].ToString();
            x.Guests.Add(gs);
            x.SaveChanges();
            int gID= x.Guests.Max(x=> x.GuestId);
            rs.GuestId = gID;
            rs.RoomId =Convert.ToInt32(HttpContext.Request.Query["roomID"]);
            rs.CheckIdDate= Convert.ToDateTime(HttpContext.Request.Query["checkIn"]);
            rs.CheckOutDate= Convert.ToDateTime(HttpContext.Request.Query["checkOUT"]);
            rs.Guest= Convert.ToInt32(HttpContext.Request.Query["guest"]);
            x.Reservations.Add(rs);
            x.SaveChanges();
            var rm = x.Rooms.Where(x=>x.RoomId == Convert.ToInt32(HttpContext.Request.Query["roomID"])).FirstOrDefault();
            rm.StatusId = 3;
            x.SaveChanges();
            var st = ST();
            var model = new MainViewModel
            {
                price = Convert.ToInt32(HttpContext.Request.Query["price"]),
                settings=st.settings,
                rsID=x.Reservations.Max(x => x.ReservationId),
                roomid= Convert.ToInt32(HttpContext.Request.Query["roomID"])

            };






            return View(model);
        }
        public ActionResult About()
        {
            var st = ST();
            var mainmodel = new MainViewModel
            {
                settings = st.settings
            };

            return View(mainmodel);
        }
        public ActionResult Contact()
        {
            var st = ST();
            var mainmodel = new MainViewModel
            {
                settings = st.settings
            };
            return View(mainmodel);
        }
        // Home /İndex/İD?
        public ActionResult RoomDetails(int? id, int roomID)
        {
            roomID = Convert.ToInt32(HttpContext.Request.Query["roomID"].ToString());

            var st = ST();
            using (var db = new HotelWebContext())
            {
                var model = db.Rooms.Where(r => r.RoomId == roomID).Include(r => r.OtherType)
    .Include(r => r.RoomType)
    .Include(r => r.Status)
    .ToList();
                byte[] cover = GetImageFromDataBase(roomID);


                var mainmodel = new MainViewModel
                {
                    rooms = model,
                    settings = st.settings



                };
                return View(mainmodel);
            }

        }
        public ActionResult Payment()
        {
            using (var db = new HotelWebContext()) { 
            int price = Convert.ToInt32(HttpContext.Request.Query["price"]);
            Payment py = new Payment();
            py.ReservetionId = Convert.ToInt32(HttpContext.Request.Query["rsID"]);
                int gID =Convert.ToInt16( db.Reservations.Where(x => x.ReservationId == py.ReservetionId).Select(x => x.GuestId).FirstOrDefault());
                py.GuestId = gID;
            py.FirstName = db.Guests.Where(x => x.GuestId == gID).Select(x => x.FirstName).FirstOrDefault();
                py.LastName = db.Guests.Where(x => x.GuestId == gID).Select(x => x.LastName).FirstOrDefault();
            py.Totalprice = price;
            db.Payments.Add(py);
                db.SaveChanges();
                var room =db.Rooms.Where(x => x.RoomId == Convert.ToInt32(HttpContext.Request.Query["roomID"])).FirstOrDefault();
                room.StatusId = 2;
                db.SaveChanges();
                
            return RedirectToAction("Index","Home");
            }
        }
        public ActionResult Reservation(int id,int roomID, DateTime checkIn,DateTime checkOUT,int guest)
        {
            roomID = Convert.ToInt32(HttpContext.Request.Query["roomID"]);
            checkIn = Convert.ToDateTime(HttpContext.Request.Query["checkIn"]);
            checkOUT = Convert.ToDateTime(HttpContext.Request.Query["checkOUT"]);
            guest = Convert.ToInt32(HttpContext.Request.Query["guest"]);
            int price;
            using (var db = new HotelWebContext())
            {
                price = (int)db.Rooms.Where(x => x.RoomId == roomID).Select(x => x.OtherType.BasePrice).FirstOrDefault();
            }
            TimeSpan day = (checkOUT - checkIn);
            int days = Convert.ToInt32(day.TotalDays);
            price = (price * (days-1));
            if (price ==0)
            {
                using (var db = new HotelWebContext())
                {
                    price = (int)db.Rooms.Where(x => x.RoomId == roomID).Select(x => x.OtherType.BasePrice).FirstOrDefault();
                }
            }
            var model =new MainViewModel
            {
                roomid = roomID,
                checkIn = checkIn,
                checkOUT = checkOUT,
                guest=guest,
                price=price,
                day=days-1
                
            };
            return View(model);
        }
        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = GetImageFromDataBase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        public ActionResult Image(int id)
        {
            byte[] cover = img(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        public MainViewModel AllRooms()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.Rooms
    .Where(z => (z.OtherTypeId == z.OtherType.OtherTypeId && z.RoomTypeId == z.RoomType.RoomTypeId && z.StatusId == z.Status.RoomStatusId) && z.StatusId==1)
    .Include(r => r.OtherType)
    .Include(r => r.RoomType)
    .Include(r => r.Status)
    .ToList();
                var mainmodel = new MainViewModel
                {
                    rooms = model,


                };
                return mainmodel;
            }
        }
        public MainViewModel OtherType()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.OtherTypes.ToList();
                var mainmodel = new MainViewModel
                {
                    othertype = model,


                };
                return mainmodel;
            }
        }
        public MainViewModel RoomType()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.RoomTypes.ToList();
                var mainmodel = new MainViewModel
                {
                    roomtype = model,


                };
                return mainmodel;
            }
        }
        public MainViewModel RoomStatus()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.RoomStatuses.ToList();
                var mainmodel = new MainViewModel
                {
                    roomstatus = model,


                };
                return mainmodel;
            }
        }
        public MainViewModel ST()
        {
            using (var db = new HotelWebContext())
            {
                var settings = db.Settings.Where(z => z.SettingsId == 1).ToList();

                var mainmodel = new MainViewModel
                {
                    settings = settings
                };

                return mainmodel;
            }
        }


        public byte[] GetImageFromDataBase(int id)
        {
            var db = new HotelWebContext();
            var q = from temp in db.Rooms where temp.RoomId == id select temp.OtherType.Image;
            byte[] cover = q.First();
            return cover;

        }
        public byte[] img(int id)
        {
            var db = new HotelWebContext();
            var q = from temp in db.Settings where temp.SettingsId == id select temp.Advertisement;
            byte[] cover = q.First();
            return cover;

        }
    }
}
