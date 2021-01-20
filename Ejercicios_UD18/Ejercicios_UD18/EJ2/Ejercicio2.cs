using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio2
    {
        public void Ejercicio()
        {
            Database empleados = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            empleados.ejecutarSQL("CREATE DATABASE ex2");
            try
            {
                empleados.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex2;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            empleados.ejecutarSQL("CREATE TABLE Departamentos (" +
                "Codigo INT NOT NULL," +
                "Nombre NVARCHAR(100)," +
                "Presupuesto INT," +
                "CONSTRAINT pk_departamentos PRIMARY KEY(Codigo)); ");

            empleados.ejecutarSQL("CREATE TABLE Empleados (" +
                "DNI VARCHAR(8) NOT NULL," +
                "Nombre NVARCHAR(100)," +
                "Apellidos NVARCHAR(255)," +
                "Departamento INT," +
                "CONSTRAINT pk_empleados PRIMARY KEY(DNI)," +
                "CONSTRAINT fk_empleados FOREIGN KEY(Departamento) REFERENCES Departamentos(Codigo)); ");

            empleados.ejecutarSQL("INSERT INTO Departamentos (Codigo,Nombre,Presupuesto) VALUES " +
                "(1,'Dep1',173)," +
                "(2,'Dep2',462)," +
                "(3,'Dep3',127)," +
                "(4,'Dep4',165)," +
                "(5,'Dep5',16);");
            empleados.ejecutarSQL("INSERT INTO Empleados (DNI,Nombre,Apellidos,Departamento) VALUES " +
                "('7491786A','Nombre1','Apellido1',1)," +
                "('7491716A','Nombre2','Apellido2',2)," +
                "('7491726A','Nombre3','Apellido3',3)," +
                "('7491736A','Nombre4','Apellido4',4)," +
                "('7491756A','Nombre5','Apellido5',5);");
            empleados.cerrarConexion();
        }
    }
}
