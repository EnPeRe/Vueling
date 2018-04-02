using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.DataAccess.Dao;
using Vueling.Presentation.WinSite;
using Vueling.DataAccess.Dao.Factories;

namespace Vueling.Business.Logic
{
    public class StudentBL : IStudentBL
    {

        public void BusinessLogic(Student student)
        {
            this.SendToDao(this.Complete(student));
        }

        private Student Complete(Student student)
        {
            //TimeSpan ts = DateTime.Now - student.FechaNacimiento;
            //student.Edad = Convert.ToInt32(ts.TotalDays)%365;

            int year = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(student.FechaNacimiento.ToString("yyyy"));
            if (student.FechaNacimiento.DayOfYear > DateTime.Now.DayOfYear) year--;
            student.Edad = year;

            return student;
        }

        private void SendToDao(Student student)
        {
            AbstarctFactory AbsFac = new FormatFactory();
            (AbsFac.CreateStudentFormat(student.SavedFormat)).Add(student);

            // StudentDAO stdao
            // stdao.DAOLogic(student);
        }

    }
}
