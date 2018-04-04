using log4net;
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

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


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
            studentBL.BusinessLogic(student);

            MessageBox.Show(String.Format("You have saved an student in {0} format", ((Button)sender).Text));

        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            this.SaveStudentData(sender);
            studentBL.BusinessLogic(student);

            MessageBox.Show(String.Format("You have saved an student in {0} format", ((Button)sender).Text));
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            this.SaveStudentData(sender);
            //StdCont.SendToBusiness(student);
            studentBL.BusinessLogic(student);

            MessageBox.Show(String.Format("You have saved an student in {0} format", ((Button)sender).Text));
        }

        private void SaveStudentData(object sender)
        {
            log.Info("Metodo SaveStudentData iniciado");
            student.Nombre = this.textBoxNombre.Text;
            student.IdAlumno = Convert.ToInt32(this.textBoxId.Text);
            student.Apellido = this.textBoxApellidos.Text;
            student.FechaNacimiento = Convert.ToDateTime(this.textBoxFechaNacimiento.Text);
            student.Dni = this.textBoxDni.Text;
            student.Student_Guid = Guid.NewGuid();
            student.SavedFormat = ((Button)sender).Text.ToLower();
            log.Info("Metodo " + System.Reflection.MethodBase.GetCurrentMethod().Name + " terminado");
        }

        private void buttonToList_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentListForm studentlist = new StudentListForm();
            studentlist.Show();
        }
    }
}
