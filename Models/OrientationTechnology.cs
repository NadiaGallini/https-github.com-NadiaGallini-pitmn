using System;

namespace Razrab.Models
{
    public class OrientationTechnology
    {
        public long Id { get; set; }
        public Technology Technology { get; set; }
        public Orientation Orientation { get; set; }
    }
}