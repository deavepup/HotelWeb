using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class OtherType
    {
        public OtherType()
        {
            Rooms = new HashSet<Room>();
        }

        public int OtherTypeId { get; set; }
        public string OtherTypeName { get; set; }
        public int? BasePrice { get; set; }
        public string Capacity { get; set; }
        public string BedType { get; set; }
        public string Services { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
