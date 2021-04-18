using System;

namespace Razrab.Models
{
    public class DirectionTraining
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public Orientation Orientation { get; set; }
    }
}