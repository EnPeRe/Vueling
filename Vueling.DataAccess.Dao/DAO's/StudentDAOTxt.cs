using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Presentation.WinSite;

namespace Vueling.DataAccess.Dao
{
    public class StudentDAOTxt : IStudentDAO
    {

        public Student Add(Student student)
        {

            string path = ConfigurationManager.AppSettings["ConfigPathTxt"].ToString();

            using (StreamWriter strw = File.AppendText(path))
            {
                strw.WriteLine(student.ToString());
            }

            return student;
        }
    }
}
