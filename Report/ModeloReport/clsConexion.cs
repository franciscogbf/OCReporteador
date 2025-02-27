﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace VistaReport
{
    public class clsConexion
    {

        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=Proyecto");
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
               
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public OdbcConnection desconexion(OdbcConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

    }
}
