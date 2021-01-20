using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio3
    {
        public void Ejercicio()
        {
            Database almacenes = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            almacenes.ejecutarSQL("CREATE DATABASE ex3");
            try
            {
                almacenes.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex3;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            almacenes.ejecutarSQL("CREATE TABLE Almacenes (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Lugar NVARCHAR(100)," +
                "Capacidad INT," +
                "CONSTRAINT pk_almacenes PRIMARY KEY(Codigo)); ");

            almacenes.ejecutarSQL("CREATE TABLE Cajas (" +
                "NumReferencia CHAR(5) NOT NULL," +
                "Contenido NVARCHAR(100)," +
                "Valor INT," +
                "Almacen INT," +
                "CONSTRAINT pk_cajas PRIMARY KEY(NumReferencia)," +
                "CONSTRAINT fk_cajas FOREIGN KEY(Almacen) REFERENCES Almacenes(Codigo)); ");

            almacenes.ejecutarSQL("INSERT INTO Almacenes (Lugar,Capacidad) VALUES " +
                "('Lugar1',43)," +
                "('Lugar2',17)," +
                "('Lugar3',8)," +
                "('Lugar4',26)," +
                "('Lugar5',30);");

            almacenes.ejecutarSQL("INSERT INTO Cajas (NumReferencia,Contenido,Valor,Almacen) VALUES " +
                "('63HF6','Piedras',90,1)," +
                "('69YA1','Piedras',80,2)," +
                "('91PK9','Piedras',10,3)," +
                "('15GP4','Piedras',100,5)," +
                "('36PA0','Piedras',60,4);");
            almacenes.cerrarConexion();
        }
    }
}
