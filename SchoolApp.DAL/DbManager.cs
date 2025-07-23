using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SchoolApp.DAL
{
    public class DbManager
    {
        public static string GetConnectionString()
        {
            return "Data Source=SchoolProj.db;Version=3;";
        }
    }
}
