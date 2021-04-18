using System;

namespace Razrab.Models
{
    public class Univercity
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public Region Region { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public DirectionTraining DirectionTraining { get; set; }

    }
}