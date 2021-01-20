using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio5
    {
        public void Ejercicio()
        {
            Database directores = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            directores.ejecutarSQL("CREATE DATABASE ex5");
            try
            {
                directores.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex5;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            directores.ejecutarSQL("CREATE TABLE Despachos (" +
                "Numero INT NOT NULL," +
                "Capacidad INT NOT NULL," +
                "CONSTRAINT pk_despachos PRIMARY KEY(Numero)); ");
            directores.ejecutarSQL("CREATE TABLE Directores (" +
                "DNI VARCHAR(8) NOT NULL," +
                "NomApels NVARCHAR(255) NOT NULL," +
                "DNIJefe VARCHAR(8)," +
                "Despacho INT," +
                "CONSTRAINT pk_directores PRIMARY KEY(DNI)," +
                "CONSTRAINT fk_directores1 FOREIGN KEY(DNIJefe) REFERENCES Directores(DNI)," +
                "CONSTRAINT fk_directores2 FOREIGN KEY(Despacho) REFERENCES Despachos(Numero)); ");
            directores.ejecutarSQL("INSERT INTO Despachos (Numero,Capacidad) VALUES" +
                "(1, 10)," +
                "(2, 13)," +
                "(3, 4)," +
                "(4, 7)," +
                "(5, 14)," +
                "(6, 11)," +
                "(7, 9)," +
                "(8, 4)," +
                "(9, 6)," +
                "(10, 16); ");
            directores.ejecutarSQL("INSERT INTO Directores (DNI,NomApels,DNIJefe,Despacho) VALUES" +
                "('5572941S', 'Jose Maria', NULL, 2)," +
                "('1192545N', 'Antonio Jose', '3426411M', 6)," +
                "('7702140V', 'Fernando Parra', NULL, 7)," +
                "('8551191H', 'Raul Alvarez', NULL, 9)," +
                "('0232404Z', 'Thais Garcia', NULL, 3)," +
                "('2128238G', 'Montse Quijano', NULL, 1)," +
                "('3426411M', 'Oriol Zahir', NULL, 6)," +
                "('1344338P', 'Carla Gomez', NULL, 4)," +
                "('6899928K', 'Jan Puro', '0232404Z', 10)," +
                "('4583267K', 'Paula Serrano', NULL, 9); ");
            directores.cerrarConexion();

        }
    }
}
