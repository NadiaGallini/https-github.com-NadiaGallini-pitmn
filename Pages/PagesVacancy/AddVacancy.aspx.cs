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
    public partial class AddVacancy : System.Web.UI.Page
    {
        AppDbContext _context;
        protected void Page_Load(object sender, EventArgs e)
        {
            _context = new AppDbContext();

            if (!IsPostBack)
            {
                
                DropDownListRegion.DataSource = _context.Region.ToList();
                DropDownListRegion.DataValueField = "Id";
                DropDownListRegion.DataTextField = "Description";
                DropDownListRegion.DataBind();
         
                
                var techs = _context.Technology.Select(x => new TechnologyDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description
                }).ToList();

                techCheckBoxList.DataSource = techs;
                techCheckBoxList.DataBind();
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Vacancy vacancy = new Vacancy();
            vacancy.Region = _context.Region.Find(int.Parse(DropDownListRegion.SelectedValue));
            vacancy.Title = TextBoxTitle.Text;
            vacancy.Address = TextBoxAddress.Text;
            vacancy.PhoneNumber = TextBoxPhoneNumber.Text;
            vacancy.ContactName = TextBoxContactName.Text;
            vacancy.FillDate = DateTime.Now;
            vacancy.Quantity = int.Parse(TextBoxQuantity.Text);
            vacancy.Sallary = int.Parse(TextBoxSallary.Text);
            _context.Vacancy.Add(vacancy);
            _context.SaveChanges();

            //_context.TechnologyVacancy.Remove(x)
            foreach (ListItem item in techCheckBoxList.Items) 
            {
                if (item.Selected)
                {
                    _context.TechnologyVacancy.Add(new TechnologyVacancy
                    {
                        Technology = _context.Technology.Find(long.Parse(item.Value)),
                        Vacancy = vacancy
                    }); 
                }
            }
            _context.SaveChanges();
            Response.Redirect("~/Pages/PagesVacancy/ListVacancy.aspx");
        }
    }
}