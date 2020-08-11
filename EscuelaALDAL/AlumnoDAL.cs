using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaALDAL
{
    //AQUI se colocan todas las operaciones que van a la base de datos a realizar alguna instruccion sql
    public class AlumnoDAL
    {
        //Pantalla consulta
        public DataTable cargarAlumnos()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=KARTOFFEL;Database=EscuelaAL;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarAlumnos";
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtAlumnos = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtAlumnos);

            connection.Close();

            return dtAlumnos;

        }

        //Pantalla alta
        public void agregarAlumno(int matricula, string nombre, DateTime fechaNacimiento, int semestre, int facultad)//variables porque ya no tenemos acceso a los controles
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=KARTOFFEL;Database=EscuelaAL;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_agregarAlumno";
            command.Connection = connection;

            //seccion para agregar parametros, command es una funcion insert into
            command.Parameters.AddWithValue("pMatricula", matricula);
            command.Parameters.AddWithValue("pNombre", nombre);
            command.Parameters.AddWithValue("pFecha", fechaNacimiento);
            command.Parameters.AddWithValue("pSemestre", semestre);
            command.Parameters.AddWithValue("pFacultad", facultad);


            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }

        //pantalla modificar
        public DataTable cargarAlumno(int matricula)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=KARTOFFEL;Database=EscuelaAL;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarAlumno";
            command.Connection = connection;

            command.Parameters.AddWithValue("pMatricula", matricula);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtAlumno = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtAlumno);

            connection.Close();

            return dtAlumno;

        }

        public void modificarAlumno(int matricula, string nombre, DateTime fechaNacimiento, int semestre, int facultad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=KARTOFFEL;Database=EscuelaAL;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_modificarAlumno";
            command.Connection = connection;

            //seccion para agregar parametros, command es una funcion insert into
            command.Parameters.AddWithValue("pMatricula", matricula);
            command.Parameters.AddWithValue("pNombre", nombre);
            command.Parameters.AddWithValue("pFecha", fechaNacimiento);
            command.Parameters.AddWithValue("pSemestre", semestre);
            command.Parameters.AddWithValue("pFacultad", facultad);


            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        //pantalla eliminar
        public void eliminarAlumno(int matricula)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=KARTOFFEL;Database=EscuelaAL;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_eliminarAlumno";
            command.Connection = connection;

            //seccion para agregar parametros, command es una funcion insert into
            command.Parameters.AddWithValue("pMatricula", matricula);


            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }


    }
}
