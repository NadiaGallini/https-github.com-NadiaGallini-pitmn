using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razrab.App_Code.Dto
{
    public class UnivercitiesDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string RegionTitle { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public int DirectionTraining_Id { get; set; }
        public int Region_Id { get; set; }
        public string Techs { get; set; }
    }
}