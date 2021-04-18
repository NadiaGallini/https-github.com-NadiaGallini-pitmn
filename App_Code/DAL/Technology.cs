using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Razrab.App_Code.DAL
{
    public class Technology
    {
        public int RowNumb { get; set; }
        public int Id { get; set; } //1
        public string Competence { get; set; }
        public string Works { get; set; }

        public Technology()
        {
            RowNumb = 0;
            Id = 0;
            Competence = string.Empty;
            Works = string.Empty;
        }

        public static Technology Map(DataRow dataRow)
        {
            Technology result = new Technology();
            result.Id = (int)dataRow["Id"];
            result.Competence = dataRow["Competence"].ToString();
            result.Works = dataRow["Works"].ToString();
            return result;
        }
        public static Technology Map(DataRow dataRow, int index)
        {//метод для подсчета строк в таблице
            Technology result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}