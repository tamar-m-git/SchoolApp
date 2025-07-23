using SchoolApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.BL
{
    public class TeacherManager
    {
        public static List<Teachers> GetAllTeachers()
        {
            return TeacherDal.GetAllTeachers();
        }

        public static Teachers GetTeacherById(int Id)
        {
            return GetAllTeachers().FirstOrDefault(t=>t.ID==Id);
        }
    }
}
