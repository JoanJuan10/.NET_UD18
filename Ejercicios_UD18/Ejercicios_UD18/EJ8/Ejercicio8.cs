using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio8
    {
        public void Ejercicio()
        {
            Database almacenes = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            almacenes.ejecutarSQL("CREATE DATABASE ex8");
            try
            {
                almacenes.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex8;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            almacenes.ejecutarSQL("CREATE TABLE Cajeros (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "NomApels NVARCHAR(255)," +
                "CONSTRAINT pk_cajeros PRIMARY KEY(Codigo)); ");

            almacenes.ejecutarSQL("CREATE TABLE Productos (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Nombre NVARCHAR(100)," +
                "Precio INT," +
                "CONSTRAINT pk_productos PRIMARY KEY(Codigo)); ");
            almacenes.ejecutarSQL("CREATE TABLE maquinas_registradas (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Piso INT," +
                "CONSTRAINT pk_maquinas PRIMARY KEY(Codigo)); ");
            almacenes.ejecutarSQL("CREATE TABLE Venta (" +
                "Cajero INT," +
                "Maquina INT," +
                "Producto INT," +
                "CONSTRAINT pk_venta PRIMARY KEY(Cajero, Maquina, Producto)," +
                "CONSTRAINT fk_venta1 FOREIGN KEY(Cajero) REFERENCES Cajeros(Codigo)," +
                "CONSTRAINT fk_venta2 FOREIGN KEY(Maquina) REFERENCES maquinas_registradas(Codigo)," +
                "CONSTRAINT fk_venta3 FOREIGN KEY(Producto) REFERENCES Productos(Codigo)); ");
            almacenes.ejecutarSQL("INSERT INTO Cajeros (NomApels) VALUES" +
                "('Cajero1')," +
                "('Cajero2')," +
                "('Cajero3')," +
                "('Cajero4')," +
                "('Cajero5')," +
                "('Cajero6')," +
                "('Cajero7')," +
                "('Cajero8')," +
                "('Cajero9')," +
                "('Cajero10'); ");
            almacenes.ejecutarSQL("INSERT INTO Productos (Nombre, Precio) VALUES" +
                "('Producto1', 362)," +
                "('Producto2', 461)," +
                "('Producto3', 26)," +
                "('Producto5', 53)," +
                "('Producto6', 10)," +
                "('Producto7', 90)," +
                "('Producto8', 112)," +
                "('Producto9', 164)," +
                "('Producto10', 265); ");
            almacenes.ejecutarSQL("INSERT INTO maquinas_registradas (Piso) VALUES" +
                "(1)," +
                "(2)," +
                "(3)," +
                "(4)," +
                "(5)," +
                "(6)," +
                "(7)," +
                "(8)," +
                "(9)," +
                "(10); ");

            almacenes.ejecutarSQL("INSERT INTO Venta (Cajero,Maquina,Producto) VALUES" +
                "(1, 6, 3)," +
                "(2, 1, 8)," +
                "(3, 8, 5)," +
                "(4, 9, 7)," +
                "(5, 4, 8)," +
                "(6, 2, 3)," +
                "(7, 7, 2)," +
                "(8, 1, 5)," +
                "(9, 6, 4)," +
                "(10, 8, 6); ");
            almacenes.cerrarConexion();

        }
    }
}
