using Razrab.App_Code.Dto;
using Razrab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Razrab.Pages.PagesVacancy
{
    public partial class ListVacancy : System.Web.UI.Page
    {
        AppDbContext _context;
        protected void Page_Load(object sender, EventArgs e)
        {
            _context = new AppDbContext();

            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            GridViewVacancy.AutoGenerateColumns = false;
            var vacs = _context.Vacancy.Include("Region").ToList();
            var vacDtos = new List<VacancyDto>();
            foreach (var vac in vacs)
            {
                vacDtos.Add(new VacancyDto
                {
                    Id = vac.Id,
                    Title = vac.Title,
                    RegionTitle = vac.Region.Title,
                    Address = vac.Address,
                    PhoneNumber = vac.PhoneNumber,
                    ContactName = vac.ContactName,
                    FillDate = vac.FillDate,
                    Quantity = vac.Quantity,
                    Sallary = vac.Sallary,
                    Techs = string.Join(",", _context.TechnologyVacancy.Where(x => x.Vacancy.Id == vac.Id).Select(y => y.Technology.Title).ToArray())
                });
            }
            GridViewVacancy.DataSource = vacDtos;
            GridViewVacancy.DataBind();
        }

        //protected void GridViewVacancy_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    int id = int.Parse(GridViewVacancy.Rows[e.RowIndex].Cells[0].Text);
        //    //DataAccessor.DeleteVacancy(id);
        //    BindGrid();
        //}


        //protected void GridViewVacancy_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    int id = int.Parse(GridViewVacancy.Rows[e.NewEditIndex].Cells[0].Text);
        //    Response.Redirect("~/Pages/PagesVacancy/EditVacancy.aspx?id=" + id);
        //}

        //protected void GridViewVacancy_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверены что хотите удалить запись?');"; // add any JS you want here
        //    }
        //}

    }
}
