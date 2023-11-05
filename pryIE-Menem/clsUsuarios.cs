using System;
using System.Data.OleDb;
using System.Windows.Forms;

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

        public class Usuario
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string User { get; set; }
            public string Contraseña { get; set; }
            public byte[] Firma { get; set; }
        }
       
        
          public bool RegistrarUsuario(string usuario, string apellido, string nomus, string contra, PictureBox firma)
          {
                using (OleDbConnection conexion = new OleDbConnection(cadenadeconexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Usuario, Contraseña, Firma) VALUES @nombre, @apellido, @usuario, @contraseña,@firma )";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("Nombre", usuario);
                        comando.Parameters.AddWithValue("Apellido", apellido);
                        comando.Parameters.AddWithValue("Usuario", nomus);
                        comando.Parameters.AddWithValue("Contraseña", contra);
                        comando.Parameters.AddWithValue("Firma", firma);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
          }

        
    }
}