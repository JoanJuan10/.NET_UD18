using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio4
    {
        public void Ejercicio()
        {
            Database cine = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            cine.ejecutarSQL("CREATE DATABASE ex4");
            try
            {
                cine.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex4;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            cine.ejecutarSQL("CREATE TABLE Peliculas (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Nombre NVARCHAR(100) NOT NULL," +
                "CalificacionEdad INT," +
                "CONSTRAINT pk_peliculas PRIMARY KEY(Codigo)); ");

            cine.ejecutarSQL("CREATE TABLE Salas (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Nombre NVARCHAR(100) NOT NULL," +
                "Pelicula INT," +
                "CONSTRAINT pk_salas PRIMARY KEY(Codigo)," +
                "CONSTRAINT fk_salas FOREIGN KEY(Pelicula) REFERENCES Peliculas(Codigo)); ");

            cine.ejecutarSQL("INSERT INTO Peliculas (Nombre,CalificacionEdad) VALUES " +
                "('Pelicula1',0)," +
                "('Pelicula2',7)," +
                "('Pelicula3',18)," +
                "('Pelicula4',0)," +
                "('Pelicula5',0);");
            cine.ejecutarSQL("INSERT INTO Salas (Nombre, Pelicula) VALUES " +
                "('Sala1',1)," +
                "('Sala2',2)," +
                "('Sala3',3)," +
                "('Sala4',4)," +
                "('Sala5',5);");
            cine.cerrarConexion();

        }
    }
}
