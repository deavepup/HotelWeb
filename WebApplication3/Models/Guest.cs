using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Guest
    {
        public Guest()
        {
            Payments = new HashSet<Payment>();
            Reservations = new HashSet<Reservation>();
        }

        public int GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
