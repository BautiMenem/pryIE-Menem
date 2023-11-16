using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Data.SqlClient;

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
            //public byte[] Firma { get; set; }
        }
       
        
          public void RegistrarUsuario(string usuario, string apellido, string nomus, string contra, Image firma)
          {
            try
            {

                using (OleDbConnection conexion = new OleDbConnection(cadenadeconexion))
                {

                    byte[] firmaBytes;
                    using (MemoryStream m = new MemoryStream())
                    {
                        firma.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                        firmaBytes = m.ToArray();
                    }

                    conexion.Open();
                    string consulta = "INSERT INTO Usuarios (Nombre, Apellido, Firma) VALUES @nombre, @apellido, @firma )";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("Nombre", usuario);
                        comando.Parameters.AddWithValue("Apellido", apellido);
                        comando.Parameters.AddWithValue("Usuario", nomus);
                        comando.Parameters.AddWithValue("Contraseña", contra);
                        comando.Parameters.AddWithValue("Firma", OleDbType.VarBinary).Value = firmaBytes;

                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se registró correctamente");
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
          }

        

    }
}