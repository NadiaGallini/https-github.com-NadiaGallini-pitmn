using System;

namespace Razrab.App_Code.Dto
{
    public class VacancyDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string RegionTitle { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public DateTime FillDate{ get; set; }
        public int Quantity { get; set; }
        public int Sallary { get; set; }
        public string Techs { get; set; }
    }
}