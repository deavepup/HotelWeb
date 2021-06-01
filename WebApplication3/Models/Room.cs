using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Room
    {
        public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int RoomId { get; set; }
        public int? RoomTypeId { get; set; }
        public int? OtherTypeId { get; set; }
        public int? StatusId { get; set; }

        public virtual OtherType OtherType { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual RoomStatus Status { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
