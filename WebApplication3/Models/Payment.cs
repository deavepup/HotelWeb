using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int GuestId { get; set; }
        public int ReservetionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Totalprice { get; set; }

        public virtual Guest Guest { get; set; }
        public virtual Reservation Reservetion { get; set; }
    }
}
