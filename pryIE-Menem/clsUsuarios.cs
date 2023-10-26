using System;
using System.Data.OleDb;

namespace pryIE_Menem
{
    internal class clsUsuarios
    {
        public string Nombre { get; set; }

        string RutaArchivo;
        string cadenadeconexion;
        string estadodeconexion;

        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataReader rd;

        public clsUsuarios()
        {
            RutaArchivo = @"../../BD/Usuarios.accdb";
            cadenadeconexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaArchivo;

        }

        public void ConectarBD()
        {
            try
            {
                conn = new OleDbConnection();
                conn.ConnectionString = cadenadeconexion;
                conn.Open();
                estadodeconexion = "Conectado";
            }
            catch (Exception x)
            {
                estadodeconexion = x.Message;
                throw;
            }

        }

        public bool Validarusuarios(string usuario, string contrasena)
        {
            using (OleDbConnection conn = new OleDbConnection(cadenadeconexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Nombre, Contrasena FROM Usuarios WHERE Nombre = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("Nombre", usuario));

                        using (OleDbDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                string usuarioBD = rd["Nombre"].ToString();
                                string contraBD = rd["Contrasena"].ToString();

                                return usuarioBD == usuario && contraBD == contrasena;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return false;

                }
            }

        }
    }
}
