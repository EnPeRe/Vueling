using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Vueling.Presentation.WinSite;

namespace Vueling.DataAccess.Dao
{
    public class StudentDAOXml : IStudentDAO
    {
        private List<Student> liststudents = new List<Student>();

        public Student Add(Student student)
        {

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


            //XmlDocument xmlDocument = new XmlDocument();
            //XmlSerializer serializer = new XmlSerializer(student.GetType());
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    serializer.Serialize(stream, student);
            //    stream.Position = 0;
            //    xmlDocument.Load(stream);
            //    xmlDocument.Save(path);
            //    stream.Close();
            //}


            /*
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                student.ToXml();
            }
            */

            return student;
        }
    }
}