using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto3.App_Code
{
    public class AppSettings
    {
        // https://www.connectionstrings.com

        public static string ConexaoDB =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            HttpContext.Current.Server.MapPath("~/App_Data/ADS Manha.accdb") +
            ";Persist Security Info=False;";
    }
}