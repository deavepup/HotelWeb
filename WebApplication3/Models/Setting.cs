using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Setting
    {
        public string SiteName { get; set; }
        public string AboutUs { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public int SettingsId { get; set; }
        public string AboutUsHeader { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public byte[] Advertisement { get; set; }
    }
}
