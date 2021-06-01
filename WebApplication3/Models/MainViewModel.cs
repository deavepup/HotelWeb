using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class MainViewModel
    {
        public List<Room> rooms { get; set; }

        public List<Setting> settings { get; set; }

        public List<OtherType> othertype { get; set; }

        public List<RoomType> roomtype { get; set; }

        public List<RoomStatus> roomstatus { get; set; }
        public List<Reservation> reservations { get; set; }

        public List<Guest> guests { get; set; }

        public List<Payment> payments { get; set; }

        public byte[] Image { get; set; }
        public IFormFile Upload { get; set; }

        public int rsID { get; set; }
        public int roomid { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOUT { get; set; }
        public int guest { get; set; }
        public int price { get; set; }
        public int day { get; set; }
    }
}
