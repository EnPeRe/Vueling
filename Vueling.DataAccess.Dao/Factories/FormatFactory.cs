using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vueling.Common.Logic.enums;

namespace Vueling.DataAccess.Dao.Factories
{
    public class FormatFactory : AbstarctFactory
    {
        public override IStudentDAO CreateStudentFormat(string type)
        {
            Config Typ = (Config)Enum.Parse(typeof(Config), type);

            switch (Typ)
            {
                case Config.txt: return new StudentDAOTxt();
                case Config.json: return new StudentDAOJson();
                case Config.xml: return new StudentDAOXml();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
