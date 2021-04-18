using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razrab.App_Code.Dto
{
    public class TechnologyDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }
    }
}