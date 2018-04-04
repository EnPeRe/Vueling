using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Vueling.DataAccess.Dao.Factories;
using Vueling.Common.Logic.Models;
using Vueling.Presentation.WinSite;

namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class StudentDaoTests
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [AssemblyInitialize]
        public static void Configure(TestContext tc)
        {
            log4net.Config.XmlConfigurator.Configure();
        }


        [TestInitialize]
        public void Initialize()
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name + " iniciado");
            
            string[] AllFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Student.*");
            foreach (string s  in AllFiles)
            {
                if(File.Exists(s)) File.Delete(s);
            }
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name + " terminado");

        }

        /*
        [TestCleanup]
        public void Cleanup()
        {
            string[] AllFiles = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Student.*");
            foreach (string s in AllFiles)
            {
                File.Delete(s);
            }
        }
        */

        [DataRow(1, "H", "J", 12, "1123-A", "12-05-1992")]
        [TestMethod()]
        public void ConstructorTest(int id, string name, string surname, int edad, string dni, string datebirth)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name + " iniciado");

            Student student = new Student(id, name, surname, edad, dni, datebirth);
            Student student2 = new Student();

            student2.IdAlumno = id;
            student2.Nombre = name;
            student2.Apellido = surname;
            student2.Edad = edad;
            student2.Dni = dni;
            student2.FechaNacimiento = Convert.ToDateTime(datebirth);

            // log.Info("student2: "+ student2.FechaNacimiento + ", stuednt:" + student.FechaNacimiento);

            Assert.IsTrue(student2.Equals(student));

            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name + " terminado");

        }



        [DataRow(1, "H", "J", 12, "1123-A", "12-05-1992")]
        [TestMethod()]
        public void TxtAddTest(int id, string name, string surname, int edad, string dni, string datebirth)
        {
            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name + " iniciado");

            Student student = new Student(id, name, surname, edad, dni, datebirth);

            AbstarctFactory formatfactory = new FormatFactory();
            IStudentDao stddao = formatfactory.CreateStudentFormat("txt");

            Student studenttest = stddao.Add(student);

            studenttest.FechaNacimiento = student.FechaNacimiento;

            log.Info("studenttest G: " + studenttest.Student_Guid + ", stuednt G:" + student.Student_Guid);

            log.Info("studenttest: " + studenttest.FechaNacimiento + ", stuednt:" + student.FechaNacimiento);
            log.Info("studenttest: " + studenttest.Nombre + ", stuednt:" + student.Nombre);
            log.Info("studenttest: " + studenttest.Edad + ", stuednt:" + student.Edad);
            log.Info("studenttest: " + studenttest.HoraRegistro + ", stuednt:" + student.HoraRegistro);
            log.Info("studenttest: " + studenttest.IdAlumno + ", stuednt:" + student.IdAlumno);
            log.Info("studenttest: " + studenttest.Apellido + ", stuednt:" + student.Apellido);
            log.Info("studenttest: " + studenttest.SavedFormat + ", stuednt:" + student.SavedFormat);
            log.Info("studenttest: " + studenttest.Dni + ", stuednt:" + student.Dni);

            Assert.IsTrue(student.Equals(studenttest));

            log.Info(System.Reflection.MethodBase.GetCurrentMethod().Name + " terminado");

        }



        [TestMethod()]
        public void GetStudentByGuidTest()
        {

        }
    }
}