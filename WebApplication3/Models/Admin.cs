using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string AdminLogin { get; set; }
        public string AdminPass { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPhone { get; set; }
    }
}
