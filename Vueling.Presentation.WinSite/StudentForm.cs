using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Models;


namespace Vueling.Presentation.WinSite
{
    public partial class StudentForm : Form
    {
        private Student student;
        private IStudentBL studentBL;
        private StudentController StdCont;

        public StudentForm()
        {
            InitializeComponent();
            student = new Student();
            studentBL = new StudentBL();
            StdCont = new StudentController();
        }

        // Botones leen textBox y llama StudentController

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            this.SaveStudentData(sender);
            //MessageBox(String.Format("You have saved an student in {0} format", (Button)sender.Text));
            //StdCont.SendToBusiness(student);
            IStudentBL stdbl = new StudentBL();
            stdbl.BusinessLogic(student);
            //this.ClearTextBoxs();
        } 

        private void buttonJson_Click(object sender, EventArgs e)
        {
            this.SaveStudentData(sender);
            StdCont.SendToBusiness(student);
            //this.ClearTextBoxs();
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            this.SaveStudentData(sender);
            StdCont.SendToBusiness(student);
            //this.ClearTextBoxs();
        }


        private void SaveStudentData(object sender)
        {
            student.Nombre = this.textBoxNombre.Text;
            student.IdAlumno = Convert.ToInt32(this.textBoxId.Text);
            student.Apellido = this.textBoxApellidos.Text;
            student.FechaNacimiento = Convert.ToDateTime(this.textBoxFechaNacimiento.Text);
            student.HoraRegistro = DateTime.Now;
            student.Dni = this.textBoxDni.Text;
            student.Student_Guid = Guid.NewGuid();
            student.SavedFormat = ((Button)sender).Text.ToLower();
        }

        private void ClearTextBoxs()
        {
            
        }
    }
}
