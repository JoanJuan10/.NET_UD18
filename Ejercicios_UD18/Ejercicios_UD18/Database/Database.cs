﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicios_UD18
{
    public class Database
    {
        private SqlConnection conexion;

        public Database (string credentials)
        {
            try
            {
                this.conexion = new SqlConnection(credentials);
                conexion.Open();
                Console.WriteLine("Conexión establecida");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public SqlConnection Conexion 
        { 
            get => conexion;
            set {
                
                try
                {
                    this.cerrarConexion();
                    this.conexion = value;
                    this.conexion.Open();
                    Console.WriteLine("Se renovó la conexión")
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public bool ejecutarSQL(string sql)
        {
            try
            {
                SqlCommand comando = new SqlCommand(sql, this.conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("SQL Ejecutado con exito | SQL EJECUTADO:");
                Console.WriteLine(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
        public void cerrarConexion ()
        {
            try
            {
                this.Conexion.Close();
                Console.WriteLine("Se cerró la conexión");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

    }
}
