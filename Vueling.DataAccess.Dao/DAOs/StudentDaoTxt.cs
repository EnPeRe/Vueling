using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.Dao
{
    public class StudentDaoTxt : IStudentDao
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public Student Add(Student student)
        {
            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name + 
                " iniciado");

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + typeof(Student).Name + ".txt";
            //string path = ConfigurationManager.AppSettings["ConfigPathTxt"].ToString();

            this.SetStudent(student, path);

            return this.GetStudentByGuid(student.Student_Guid, path);
        }


        private void SetStudent(Student student, string path)
        {
            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name +
                " iniciado");
            if (!File.Exists(path))
            {
                using (StreamWriter stwriter = File.CreateText(path))
                {
                    stwriter.WriteLine(student.ToString());
                }
            }
            else
            {
                using (StreamWriter strw = File.AppendText(path))
                {
                    strw.WriteLine(student.ToString());
                }
                //File.AppendAllText(path, student.ToString() + Environment.NewLine);
            }
            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name +
                " terminado");

        }

        private Student GetStudentByGuid(Guid studentguid, string path)
        {
            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name +
                " iniciado");
            var alllines = File.ReadAllLines(path);
            string findstudent = "";
            foreach (string line in alllines)
            {
                if (line.Contains(studentguid.ToString()))
                {
                    findstudent = line;
                } 
            }

            var linesplit = findstudent.Split(',');
            Student readstudent = new Student(Int32.Parse(linesplit[0]), linesplit[1], linesplit[2], Int32.Parse(linesplit[3]), linesplit[4], linesplit[5], linesplit[6]);


            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name +
                " terminado");
            log.Info("Datos del student leido del file txt:");
            log.Info("datebirth:" + readstudent.FechaNacimiento.ToString());
            return readstudent;
        }

    }
}
