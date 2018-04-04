using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Models
{
    public class VuelingModelObject
    {
        private Guid guid;

        public virtual string ToJson()
        {
            //StringBuilder stb;
            //No concatenar con "+", utilizar StringBuilder
            return String.Format("[{Guid:" + guid.ToString() + "}]"); 
        }

        public virtual string ToXml()
        {
            return guid.ToString(); // Escribir manualmente el guid en formato xml
        }

    }
}
