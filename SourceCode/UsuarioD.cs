using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;

namespace SourceCode
{
    public static class UsuarioD
    {
        public static List<Usuario> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.userid = fila[0].ToString();
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.contrasena = fila[3].ToString();
                u.usertype = Convert.ToBoolean(fila[4].ToString());
                

                lista.Add(u);
            }
            return lista;
        }//
        public static void actualizarContra(string username, string nuevaContra)
        {
            string sql = String.Format(
                "UPDATE APPUSER SET password = '{0}' WHERE username = '{1}'", 
                nuevaContra, username);
            
            Conexion.realizarAccion(sql);
        }//
        //UPDATE APPUSER SET password = 'nueva' WHERE idUser = 1
        //update APPUSER set password='{0}' where userid='{1}';
        
        public static void crearNuevo(string username)
                {
                    string sql = String.Format(
                        "INSERT INTO APPUSER(fullname, username, password, userType)" +
                        "values('{0}', '{1}', '{2}', false);",
                        username, username,username);
                    
                    Conexion.realizarAccion(sql);
                }
        
        public static void eliminar(string username)
        {
            string sql = String.Format(
                "DELETE FROM APPUSER WHERE USERNAME = '{0}'", 
                username);
            
            Conexion.realizarAccion(sql);
        }

    }
}