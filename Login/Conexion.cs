using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace CapaDiseño
{
    public class Conexion
    {
       
            public static  string StrConexion;
            private OleDbConnection ObjConexion;
            private SIDIBDataSet miDataSet = new SIDIBDataSet();
            
        public static string Con()
        {
            StrConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Proyecto\SIDIB.accdb";
            return StrConexion;
        }
            
            public static OleDbConnection Cn_conexion()
            {
                OleDbConnection CadenaConexion = new OleDbConnection(Con());

                return CadenaConexion;
            }
            public void Cadena_Conexion(string Conexion)
            {
                //StrConexion = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Proyecto\SIDIB.accdb") + Conexion;
                ObjConexion = new OleDbConnection(StrConexion);
            }


            public int Ejecutar_sql(string sql)
            {
                // Insertar en la BD
                int i = 0;
                try
                {
                    ObjConexion.Open();
                    OleDbCommand Cmd = new OleDbCommand(sql, ObjConexion);
                    i = Cmd.ExecuteNonQuery();

                }
                catch
                {

                }
                i = -1;
                return i;
            }
        }
}
