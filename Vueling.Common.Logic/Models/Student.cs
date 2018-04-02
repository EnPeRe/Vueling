using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Models;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Vueling.Presentation.WinSite
{
    //[Serializable, XmlRoot("enric.pedros")]
    public class Student : VuelingModelObject
    {
        #region Atributos
        private int idAlumno;
        private string nombre;
        #endregion

        #region Properties
        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido { get; set; }
        public string Dni { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime HoraRegistro { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public string SavedFormat { get; set; }
        public Guid Student_Guid { get; set; }
        #endregion

        public override string ToString()
        {
            //return base.ToString();
            string tostring = this.IdAlumno + "," + this.Nombre + "," + this.Apellido + "," + this.Edad + "," + this.HoraRegistro + "," + this.Dni + "," + this.Student_Guid;
            return tostring;
        }

        public string ToJson()
        {
            //return "{\"Nombre\":\"" + this.Nombre + "\",\"Id\":" + this.Id + ",\"Edad\":" + this.Edad + ",\"Dni\":\"" + this.Dni + "\",\"Guid\":" + this.Al_Guid + "}";
            return "[" + JsonConvert.SerializeObject(this) + "]";

        }

        public string ToXml()
        {

            //new XDocument( new XElement("root", new XElement("someNode", "someValue"))).Save("foo.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, this);
                return textWriter.ToString();
            }
        }
    }
}
