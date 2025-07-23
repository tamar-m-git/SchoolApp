using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Net;
using System.Security.Claims;


namespace SchoolApp.DAL
{
    public class StudentDal
    {public static List<Students> GetAllStudents()
        {
            List<Students> students = new List<Students>();
            using (var conn = new SQLiteConnection("Data Source=SchoolProj.db"))
            {
                conn.Open();
                var command = new SQLiteCommand("SELECT * FROM Students", conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var student = new Students
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        HomePhone = reader.GetString(3),
                        BirthdayYear = reader.GetInt32(4),
                        Class = reader.GetString(5),
                        Address = reader.GetString(6)
                    };
                    students.Add(student);
                }
                return students;


            }

            // ID, FirstName, LastName, HomePhone, BirthdayYear, Class, Address
        }
    }
}



