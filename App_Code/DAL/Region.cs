using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Razrab.App_Code.DAL
{
    public class Region
    {
        public int RowNumb { get; set; }
        public int Id { get; set; } //1
        public string Description { get; set; }

        public Region()
        {
            RowNumb = 0;
            Id = 0;
            Description = string.Empty;
        }

        public static Region Map(DataRow dataRow)
        {
            Region result = new Region();
            result.Id = (int)dataRow["Id"];
            result.Description = dataRow["Description"].ToString();
            return result;
        }
        public static Region Map(DataRow dataRow, int index)
        {//метод для подсчета строк в таблице
            Region result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}