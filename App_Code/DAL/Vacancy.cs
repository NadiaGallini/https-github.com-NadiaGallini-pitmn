using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Razrab.App_Code.DAL
{
    public class Vacancy
    {
        public int RowNumb { get; set; }
        public int Id { get; set; } //1
        public int RegionId { get; set; } //2
        public string Description { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public DateTime? DateFilling { get; set; }
        public int Quantity { get; set; } //1
        public decimal Sallary { get; set; }
        public string Competence { get; set; }
        public Vacancy()
        {
            RowNumb = 0;
            Id = 0;
            RegionId = 0;
            Description = string.Empty;
            Title = string.Empty;
            Address = string.Empty;
            PhoneNumber = string.Empty;
            ContactName = string.Empty;
            DateFilling = null;
            Quantity = 0;
            Sallary = 0.0m;
            Competence = string.Empty;
        }

        public static Vacancy Map(DataRow dataRow)
        {
            Vacancy result = new Vacancy();
            result.Id = (int)dataRow["Id"];
            result.RegionId = (int)dataRow["RegionId"];
            result.Description = dataRow["Description"].ToString();
            result.Title = dataRow["Title"].ToString();
            result.Address = dataRow["Address"].ToString();
            result.PhoneNumber = dataRow["PhoneNumber"].ToString();
            result.ContactName = dataRow["ContactName"].ToString();
            result.DateFilling = dataRow["DateFilling"] != DBNull.Value ? (DateTime?)dataRow["DateFilling"] : null;
            result.Quantity = int.Parse(dataRow["Quantity"].ToString());
            result.Sallary = (decimal)dataRow["Sallary"];
            result.Competence = dataRow["Competence"].ToString();
            return result;
        }

        public static Vacancy Map(DataRow dataRow, int index)
        {//метод для подсчета строк в таблице
            Vacancy result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}