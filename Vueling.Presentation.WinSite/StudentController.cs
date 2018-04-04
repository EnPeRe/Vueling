using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Models;

namespace Vueling.Presentation.WinSite
{
    class StudentController
    {
        // Metodo para enviar Alumno a Business.Studentomplete
        public void SendToBusiness(Student std)
        {
            IStudentBL stdbl = new StudentBL();
            stdbl.BusinessLogic(std);
        }
    }
}
