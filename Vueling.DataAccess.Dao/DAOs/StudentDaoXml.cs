using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.Dao
{
    public class StudentDaoXml : IStudentDao
    {
        private List<Student> liststudents;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public Student Add(Student student)
        {
            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name +
                " iniciado");
            liststudents = new List<Student>();

            string path = ConfigurationManager.AppSettings["ConfigPathXml"].ToString();
            XmlSerializer serializer = new XmlSerializer(liststudents.GetType());

            if (File.Exists(path))
            {
                using (TextReader reader = new StreamReader(path))
                {
                    String readtoend = reader.ReadToEnd();
                    StringReader streader = new StringReader(readtoend);
                    liststudents = (List<Student>)serializer.Deserialize(streader);
                }
                using (TextWriter writer = new StreamWriter(path))
                {
                    liststudents.Add(student);
                    serializer.Serialize(writer, liststudents);
                }
            }
            else
            {
                using (TextWriter writer = new StreamWriter(path))
                {
                    liststudents.Add(student);
                    serializer.Serialize(writer, liststudents);
                }
            }

            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name +
                " terminado");
            return student;
        }
    }
}