using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.DataAccess.Dao.Factories
{
    public abstract class AbstarctFactory
    {
        // return el tipo de formato
        public abstract IStudentDao CreateStudentFormat(string str);
    }
}
