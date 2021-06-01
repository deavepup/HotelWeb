using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            Payments = new HashSet<Payment>();
        }

        public int ReservationId { get; set; }
        public int? GuestId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? CheckIdDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? Guest { get; set; }

        public virtual Guest GuestNavigation { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
