using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using System.IO;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            var room = AllRooms();
            var roomStatus = RoomStatus();
            var roomType = RoomType();
            var mainmodel = new MainViewModel
            {
                roomstatus = roomStatus.roomstatus,
                roomtype = roomType.roomtype,
                rooms = room.rooms

            };
            return View(mainmodel);
        }

        public async Task<ActionResult> Login(int id,Models.Admin p)
        {
            var db = new HotelWebContext();
            if (HttpContext.Request.Query.Count > 1)
            {
                p.AdminLogin = HttpContext.Request.Query["login"].ToString();
                p.AdminPass = HttpContext.Request.Query["password"].ToString();
                var respons = db.Admins.FirstOrDefault(x => x.AdminLogin == p.AdminLogin && x.AdminPass == p.AdminPass);
                if (respons != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.AdminLogin)
                };
                    var adminidentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(adminidentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Admin");
                }
                
            }

            return View();
        }

        [Authorize]
        public ActionResult RoomList()
        {
            var rooms = AllRooms();

            var mainmodel = new MainViewModel
            {
                rooms = rooms.rooms,


            };




            return View(mainmodel);
        }
        [Authorize]
        public ActionResult deletePayment(int id, int pID)
        {

            pID = Convert.ToInt32(HttpContext.Request.Query["pID"]);
            var db = new HotelWebContext();
            var payment = db.Payments.FirstOrDefault(x => x.PaymentId == pID);
            db.Payments.Remove(payment);
            db.SaveChanges();
            return RedirectToAction("paymentList", "Admin");
        }
        [Authorize]
        public ActionResult paymentList()
        {
            var model = AllPayments();
            var mainmodel = new MainViewModel
            {
                payments = model.payments,


            };

            return View(mainmodel);
        }
        [Authorize]
        public ActionResult editGuest(int id, int gID)
        {
            var db = new HotelWebContext();
            gID = Convert.ToInt32(HttpContext.Request.Query["gID"]);
            if (HttpContext.Request.Query.Count > 1)
            {
                var guest = db.Guests.FirstOrDefault(x => x.GuestId == gID);
                guest.FirstName = HttpContext.Request.Query["Name"].ToString();
                guest.LastName = HttpContext.Request.Query["surName"].ToString();
                guest.Adress = HttpContext.Request.Query["adress"].ToString();
                guest.Email = HttpContext.Request.Query["email"].ToString();
                guest.Phone = HttpContext.Request.Query["phone"].ToString();
                guest.Country = HttpContext.Request.Query["country"].ToString();
                guest.City = HttpContext.Request.Query["city"].ToString();
                db.SaveChanges();
                return RedirectToAction("guestList", "Admin");
            }
            else
            {

                var guest = db.Guests.Where(x => x.GuestId == gID).ToList();

                var mainmodel = new MainViewModel
                {
                    guests = guest
                };
                return View(mainmodel);
            }


        }
        public ContentResult delGuest()
        {
            string a = "<br/><a href=\"/Admin/Admin/reservationList \"style=\"color:red;font-size:30px;text-decoration: none; \">Rezervasyon Listesi</a>";
            return Content("<h1>Misafiri silebilmeniz icin once misafirin rezervasyonunu silmelisiniz</h1>" + a, "text/html");
        }
        [Authorize]
        public ActionResult deleteGuest(int id, int gID)
        {
            var db = new HotelWebContext();
            gID = Convert.ToInt32(HttpContext.Request.Query["gID"]);
            int r = db.Reservations.Where(x => x.GuestId == gID).Count();
            if (r == 0)
            {
                var guest = db.Guests.Where(x => x.GuestId == gID).FirstOrDefault();
                db.Guests.Remove(guest);
                db.SaveChanges();
                return RedirectToAction("guestList", "Admin");
            }
            else
            {
                return RedirectToAction("delGuest", "Admin");
            }

        }
        [Authorize]
        public ActionResult guestList()
        {
            var guest = AllGuest();
            var mainmodel = new MainViewModel
            {
                guests = guest.guests
            };
            return View(mainmodel);
        }
        [Authorize]
        public ActionResult reservationList()
        {
            var a = AllReservation();
            var mainmodel = new MainViewModel
            {
                reservations = a.reservations

            };
            return View(mainmodel);
        }
        [Authorize]
        public ActionResult addRoom()
        {
            if (HttpContext.Request.Query.Count != 0)
            {
                Room rm = new Room();
                OtherType ot = new OtherType();
                var db = new HotelWebContext();
                ot.OtherTypeName = HttpContext.Request.Query["roomName"].ToString();
                rm.RoomTypeId = Convert.ToInt32(HttpContext.Request.Query["roomTypeName"]);
                ot.BasePrice = Convert.ToInt32(HttpContext.Request.Query["price"]);
                rm.StatusId = Convert.ToInt32(HttpContext.Request.Query["roomStatusName"]);
                ot.Capacity = HttpContext.Request.Query["capacity"].ToString();
                ot.BedType = HttpContext.Request.Query["bedType"].ToString();
                ot.Services = HttpContext.Request.Query["services"].ToString();
                rm.OtherType = ot;
                db.Rooms.Add(rm);
                db.SaveChanges();
                return RedirectToAction("RoomList", "Admin");
            }
            else
            {
                var roomStatus = RoomStatus();
                var roomType = RoomType();
                var mainmodel = new MainViewModel
                {
                    roomstatus = roomStatus.roomstatus,
                    roomtype = roomType.roomtype

                };
                return View(mainmodel);
            }

        }
        [Authorize]
        public ActionResult SiteSettings()
        {
            var st = ST();
            var mainmodel = new MainViewModel
            {
                settings = st.settings
            };


            return View(mainmodel);
        }
        [Authorize]
        public ActionResult editReservation(int id, int resID)
        {
            var db = new HotelWebContext();
            resID = Convert.ToInt32(HttpContext.Request.Query["resID"]);
            if (HttpContext.Request.Query.Count > 1)
            {
                var res = db.Reservations.Where(x => x.ReservationId == resID).FirstOrDefault();
                res.RoomId = Convert.ToInt32(HttpContext.Request.Query["roomID"]);
                res.GuestId = Convert.ToInt32(HttpContext.Request.Query["guestID"]);
                res.CheckIdDate = Convert.ToDateTime(HttpContext.Request.Query["inDate"]);
                res.CheckOutDate = Convert.ToDateTime(HttpContext.Request.Query["outDate"]);
                res.Guest = Convert.ToInt32(HttpContext.Request.Query["guest"]);
                db.SaveChanges();
                return RedirectToAction("reservationList", "Admin");
            }
            else
            {


                var res = db.Reservations.Where(x => x.ReservationId == resID).ToList();
                DateTime inDate = Convert.ToDateTime(db.Reservations.Where(x => x.ReservationId == resID).Select(x => x.CheckOutDate).FirstOrDefault());
                DateTime outDate = Convert.ToDateTime(db.Reservations.Where(x => x.ReservationId == resID).Select(x => x.CheckOutDate).FirstOrDefault());
                var room = AllRooms();
                var guest = AllGuest();
                var mainmodel = new MainViewModel
                {
                    reservations = res,
                    rooms = room.rooms,
                    guests = guest.guests,
                    checkIn = inDate,
                    checkOUT = outDate,
                };
                return View(mainmodel);
            }

        }
        [Authorize]
        public ActionResult deleteRes(int id, int resID)
        {
            resID = Convert.ToInt32(HttpContext.Request.Query["resID"]);
            using (var db = new HotelWebContext())
            {
                var deleteres = db.Reservations.Where(z => z.ReservationId == resID).FirstOrDefault();
                db.Reservations.Remove(deleteres);
                db.SaveChanges();

                return RedirectToAction("reservationList", "Admin");
            };
        }
        [Authorize]
        public ActionResult DeleteRoom(int id, int roomID)
        {
            roomID = Convert.ToInt32(HttpContext.Request.Query["roomID"]);
            using (var db = new HotelWebContext())
            {
                var deleteRoom = db.Rooms.Where(z => z.RoomId == roomID).FirstOrDefault();
                db.Rooms.Remove(deleteRoom);
                db.SaveChanges();

                return RedirectToAction("RoomList", "Admin");
            };
        }
        [Authorize]
        public ActionResult EditRoom(int id, int roomID)
        {
            roomID = Convert.ToInt32(HttpContext.Request.Query["roomID"]);
            using (var db = new HotelWebContext())
            {
                var room = db.Rooms.Where(z => z.RoomId == roomID).Include(r => r.OtherType)
       .Include(r => r.RoomType)
       .Include(r => r.Status).ToList();
                var roomStatus = RoomStatus();
                var roomType = RoomType();
                var mainmodel = new MainViewModel
                {
                    roomstatus = roomStatus.roomstatus,
                    roomtype = roomType.roomtype,
                    rooms = room

                };

                return View(mainmodel);
            };


        }
        [Authorize]
        public ActionResult editRm(int id)
        {

            using (var db = new HotelWebContext())
            {
                Room room = new Room();
                var roomID = Convert.ToInt32(HttpContext.Request.Query["roomID"]);
                room = db.Rooms.Where(x => x.RoomId == roomID)
                    .Include(r => r.OtherType)
    .Include(r => r.RoomType)
    .Include(r => r.Status)
    .FirstOrDefault();
                room.StatusId = Convert.ToInt32(HttpContext.Request.Query["roomStatusName"]);
                room.RoomTypeId = Convert.ToInt32(HttpContext.Request.Query["roomTypeName"]);

                room.OtherType.BasePrice = Convert.ToInt32(HttpContext.Request.Query["price"]);
                room.OtherType.Capacity = HttpContext.Request.Query["capacity"].ToString();
                room.OtherType.BedType = HttpContext.Request.Query["bedType"].ToString();
                room.OtherType.Services = HttpContext.Request.Query["services"].ToString();
                room.OtherType.OtherTypeName = HttpContext.Request.Query["roomName"].ToString();
                db.SaveChanges();
            }
            return RedirectToAction("RoomList", "Admin");
        }
        [Authorize]
        public ActionResult editST(int id)
        {
            using (var db = new HotelWebContext())
            {
                var st = db.Settings.Where(x => x.SettingsId == 1).FirstOrDefault();
                st.SiteName = HttpContext.Request.Query["siteName"].ToString();
                st.Email = HttpContext.Request.Query["email"].ToString();
                st.Phone = HttpContext.Request.Query["phone"].ToString();
                st.Fax = HttpContext.Request.Query["fax"].ToString();
                st.Address = HttpContext.Request.Query["adress"].ToString();
                st.Location = HttpContext.Request.Query["location"].ToString();
                st.AboutUsHeader = HttpContext.Request.Query["header"].ToString();
                st.AboutUs = HttpContext.Request.Query["aboutUS"].ToString();
                db.SaveChanges();
            }





            return RedirectToAction("SiteSettings", "Admin");
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
        public MainViewModel AllReservation()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.Reservations
    .Where(z => z.GuestId == z.GuestNavigation.GuestId && z.RoomId == z.Room.RoomId)
    .Include(r => r.GuestNavigation)
    .Include(r => r.Room)
    .ToList();
                var mainmodel = new MainViewModel
                {
                    reservations = model,


                };
                return mainmodel;
            }
        }
        public MainViewModel AllRooms()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.Rooms
    .Where(z => z.OtherTypeId == z.OtherType.OtherTypeId && z.RoomTypeId == z.RoomType.RoomTypeId && z.StatusId == z.Status.RoomStatusId)
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
        public MainViewModel AllPayments()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.Payments
    .Include(r => r.Reservetion)
    .Include(r => r.Guest)
    .ToList();
                var mainmodel = new MainViewModel
                {
                    payments = model,


                };
                return mainmodel;
            }
        }
        public MainViewModel AllGuest()
        {
            using (var db = new HotelWebContext())
            {
                var model = db.Guests
    .Include(r => r.Reservations)
    .Include(r => r.Payments)
    .ToList();
                var mainmodel = new MainViewModel
                {
                    guests = model,


                };
                return mainmodel;
            }
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
        public byte[] GetImageFromDataBase(int id)
        {
            var db = new HotelWebContext();
            var q = from temp in db.Rooms where temp.RoomId == id select temp.OtherType.Image;
            byte[] cover = q.First();
            return cover;

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
    }
}
