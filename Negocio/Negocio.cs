using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OleDb;

namespace CapaNegocio
{
    public static class Negocio
    {
        
        //public static string rol;
        public static string nUsuario;
        public static string user;
        public static string pass;
      
        
        public static int espaciosSolos(string pUsuario, string pContraseña, string pNombres )
        {
            int solos = 0;
            if (pUsuario == "" || pContraseña == "" || pNombres == "" )
            {
                solos = 1;
            }
            return solos;
        }
       
    }
}
