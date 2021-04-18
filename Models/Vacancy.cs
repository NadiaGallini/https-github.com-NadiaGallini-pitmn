using System;

namespace Razrab.Models
{
    public class Vacancy
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string OrganizationName { get; set; }
        public Region Region { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public DateTime FillDate{ get; set; }
        public int Quantity { get; set; }
        public int Sallary { get; set; }
    }
}