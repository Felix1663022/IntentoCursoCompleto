using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscuelaALDAL;

namespace EscuelaAL_BLL
{
    public class AlumnoBLL
    {
        //BLL llamadas a los metodos de la DAL
        public DataTable cargarAlumnos()
        {
            AlumnoDAL alumno = new AlumnoDAL();
            return alumno.cargarAlumnos();
        }

        public void agregarAlumno(int matricula, string nombre, DateTime fechaNacimiento, int semestre, int facultad)
        {
            AlumnoDAL alumno = new AlumnoDAL();
            alumno.agregarAlumno(matricula, nombre, fechaNacimiento, semestre, facultad);
        }

        public DataTable cargarAlumno(int matricula)
        {
            AlumnoDAL alumno = new AlumnoDAL();
            return alumno.cargarAlumno(matricula);
        }

        public void modificarAlumno(int matricula, string nombre, DateTime fechaNacimiento, int semestre, int facultad)
        {
            AlumnoDAL alumno = new AlumnoDAL();
            alumno.modificarAlumno(matricula, nombre, fechaNacimiento, semestre, facultad);
        }

        public void eliminarAlumno(int matricula)
        {
            AlumnoDAL alumno = new AlumnoDAL();
            alumno.eliminarAlumno(matricula);
        }
    }
}
