using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio6
    {
        public void Ejercicio()
        {
            Database piezas = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            piezas.ejecutarSQL("CREATE DATABASE ex6");
            try
            {
                piezas.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex6;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            piezas.ejecutarSQL("CREATE TABLE Proveedores (" +
                "Id CHAR(4) NOT NULL," +
                "Nombre NVARCHAR(100) NOT NULL," +
                "CONSTRAINT pk_proveedores PRIMARY KEY(Id)); ");
            piezas.ejecutarSQL("CREATE TABLE Piezas (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Nombre NVARCHAR(100) NOT NULL," +
                "CONSTRAINT pk_piezas PRIMARY KEY(Codigo)); ");
            piezas.ejecutarSQL("CREATE TABLE Suministra (" +
                "CodigoPieza INT NOT NULL," +
                "IdProveedor CHAR(4) NOT NULL," +
                "Precio INT NOT NULL," +
                "CONSTRAINT pk_suministra PRIMARY KEY(CodigoPieza, IdProveedor)," +
                "CONSTRAINT fk_suministra1 FOREIGN KEY(CodigoPieza) REFERENCES Piezas(Codigo)," +
                "CONSTRAINT fk_suministra2 FOREIGN KEY(IdProveedor) REFERENCES Proveedores(Id)); ");

            piezas.ejecutarSQL("INSERT INTO Piezas (Nombre) VALUES" +
                "('Tuerca')," +
                "('Tornillo')," +
                "('Llave')," +
                "('Arandela')," +
                "('Piston')," +
                "('Cuerda')," +
                "('Pieza1')," +
                "('Pieza2')," +
                "('Pieza3')," +
                "('Pieza4'); ");

            piezas.ejecutarSQL("INSERT INTO Proveedores (Id,Nombre) VALUES " +
                "('1', 'Bosh')," +
                "('2', 'Balay')," +
                "('3', 'Proveedor3')," +
                "('4', 'Proveedor4')," +
                "('5', 'Proveedor5')," +
                "('6', 'Proveedor6')," +
                "('7', 'Proveedor7')," +
                "('8', 'Proveedor8')," +
                "('9', 'Proveedor9')," +
                "('10', 'Proveedor10'); ");

            piezas.ejecutarSQL("INSERT INTO Suministra (CodigoPieza,IdProveedor,Precio) VALUES" +
                "(3, '2', 583)," +
                "(1, '4', 824)," +
                "(2, '8', 16)," +
                "(6, '5', 3)," +
                "(8, '1', 8)," +
                "(4, '2', 123)," +
                "(7, '9', 632)," +
                "(5, '10', 41)," +
                "(6, '8', 28)," +
                "(10, '3', 18); ");
            piezas.cerrarConexion();

        }
    }
}
