using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.DAL;

namespace SchoolApp.BL
{
    public class StudentManager
    {
        public static List<Students> GetAllStudents()
        {
            return StudentDal.GetAllStudents();
        }

        public static List<Students> GetStudentsByClass(string className)
        {
            return GetAllStudents().Where(s => s.Class == className).ToList();
        }
    }
}
