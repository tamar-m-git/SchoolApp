using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.DAL
{
    public class TeacherDal
    {
        public static List<Teachers> GetAllTeachers()
        {
            List<Teachers> Teachers= new List<Teachers>();
            using (var conn = new SQLiteConnection("Data Source=SchoolProj.db"))
            {
                conn.Open();
                var command = new SQLiteCommand("SELECT * FROM Teachers", conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var Teacher = new Teachers
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        MailAddress = reader.GetString(4)
                    };
                  
                    Teachers.Add(Teacher);

                }
                return Teachers;


            }

        }
    }
}
