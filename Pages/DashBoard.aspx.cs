using Razrab.App_Code.Dto;
using Razrab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Razrab.Pages
{
    public partial class DashBoard : System.Web.UI.Page
    {
        //AppDbContext _context;
        protected void Page_Load(object sender, EventArgs e)
        {
            //_context = new AppDbContext();

            //if (!IsPostBack)
            //{
            //    BindGrid();
            //}
        }
        //private void BindGrid()
        //{
        //    GridViewUniver.AutoGenerateColumns = false;
        //    var vacs = _context.Univercity.Include("Region").ToList();
        //    var vacDtos = new List<UnivercitiesDto>();
        //    foreach (var vac in vacs)
        //    {
        //        vacDtos.Add(new UnivercitiesDto
        //        {
        //            Id = vac.Id,
        //            Title = vac.Title,
        //            RegionTitle = vac.Region.Title,
        //            Address = vac.Address,
        //            PhoneNumber = vac.PhoneNumber,
        //            ContactName = vac.ContactName,
        //            DirectionTraining_Id = vac.DirectionTraining.Id,
        //            Techs = string.Join(",", _context.OrientationTechnology.Where(x => x.Orientation.Id == vac.Id).Select(y => y.Technology.Title).ToArray())
        //        }) ;
        //    }
        //    GridViewUniver.DataSource = vacDtos;
        //    GridViewUniver.DataBind();
        //}
     }
}