using Newtonsoft.Json;
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
    public class StudentDAOJson : IStudentDAO
    {
        private List<Student> liststudents = new List<Student>();
        public Student Add(Student student)
        {
            string path = ConfigurationManager.AppSettings["ConfigPathJson"].ToString();

            if (File.Exists(path))
            {
                using (TextReader reader = new StreamReader(path))
                {
                    liststudents = JsonConvert.DeserializeObject<List<Student>>(reader.ReadToEnd());
                }
                using (TextWriter writer = new StreamWriter(path))
                {
                    liststudents.Add(student);
                    writer.Write(JsonConvert.SerializeObject(liststudents));
                }
            }
            else
            {
                using (TextWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(student.ToJson());
                }
            }


/*
            if (!File.Exists(path))
            {
                using (TextWriter writer = new StreamWriter(path, append: true))
                {
                    writer.WriteLine("[" + student.ToJson() + "]");
                }

            }
            else
            {
                using(StreamReader reader = new StreamReader(path))
                {
                    string json = reader.ReadToEnd();
                    using (TextWriter writer = new StreamWriter(path, append: true))
                    {
                        string jsonreplaced = json.Replace(']', ',');
                        writer.WriteLine(student.ToJson() + "]");
                    }


                }
            }
*/

            return student;

        }
    }
}
