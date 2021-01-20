using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    class Ejercicio1
    {
        public void Ejercicio()
        {
            Database tiendaInformatica = new Database("Data Source=192.168.1.53;Initial Catalog=master;Persist Security Info=True;User ID=user123;Password=123");
            tiendaInformatica.ejecutarSQL("CREATE DATABASE ex1");
            try
            {
                tiendaInformatica.Conexion = new SqlConnection("Data Source=192.168.1.53;Initial Catalog=ex1;Persist Security Info=True;User ID=user123; Password=123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            tiendaInformatica.ejecutarSQL("CREATE TABLE Fabricantes " +
                "(Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Nombre NVARCHAR(100)," +
                "CONSTRAINT pk_fabricantes PRIMARY KEY(Codigo)); ");
            tiendaInformatica.ejecutarSQL("CREATE TABLE Articulos (" +
                "Codigo INT NOT NULL IDENTITY(1, 1)," +
                "Nombre NVARCHAR(100)," +
                "Precio INT," +
                "Fabricante INT," +
                "CONSTRAINT pk_articulos PRIMARY KEY(Codigo)," +
                "CONSTRAINT fk_articulos FOREIGN KEY(Fabricante) REFERENCES Fabricantes(Codigo)); ");
            tiendaInformatica.ejecutarSQL("INSERT INTO Fabricantes (Nombre) VALUES " +
                "('Fabricante1')," +
                "('Fabricante2')," +
                "('Fabricante3')," +
                "('Fabricante4')," +
                "('Fabricante5');");
            tiendaInformatica.ejecutarSQL("INSERT INTO Articulos (Nombre, Precio, Fabricante) VALUES " +
                "('Articulo1',10,1)," +
                "('Articulo2',10,2)," +
                "('Articulo3',10,3)," +
                "('Articulo4',10,4)," +
                "('Articulo5',10,5);");

        }
    }
}
