using System;

namespace Razrab.Models
{
    public class TechnologyVacancy
    {
        public long Id { get; set; }
        public Vacancy Vacancy { get; set; }
        public Technology Technology { get; set; }
    }
}