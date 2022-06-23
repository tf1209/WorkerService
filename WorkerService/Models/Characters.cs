using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkerService.Models
{
    public partial class Characters
    {
        public int CharactersId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public byte? Power { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Alias { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }
        public string Occupation { get; set; }
        public string Image { get; set; }
    }
}
