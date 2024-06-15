using ProyectoWebAPI.Models;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoWebAPI.Data
{
    public class CitaData
    {
        public static bool Registrar(Cita oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nroDocumento", oUsuario.NroDocumento);
                cmd.Parameters.AddWithValue("@nombres", oUsuario.Nombres);
                cmd.Parameters.AddWithValue("@especialidad", oUsuario.Especialidad);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool Modificar(Cita oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_modificar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCita", oUsuario.IdCita);
                cmd.Parameters.AddWithValue("@nroDocumento", oUsuario.NroDocumento);
                cmd.Parameters.AddWithValue("@nombres", oUsuario.Nombres);
                cmd.Parameters.AddWithValue("@especialidad", oUsuario.Especialidad);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static List<Cita> Listar()
        {
            List<Cita> oListaUsuario = new List<Cita>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_listar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaUsuario.Add(new Cita()
                            {
                                IdCita = Convert.ToInt32(dr["IdCita"]),
                                NroDocumento = dr["NroDocumento"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Especialidad = dr["Especialidad"].ToString(),
                                Fecha = Convert.ToDateTime(dr["Fecha"].ToString())
                            });
                        }

                    }



                    return oListaUsuario;
                }
                catch (Exception ex)
                {
                    return oListaUsuario;
                }
            }
        }

        public static Cita Obtener(int idcita)
        {
            Cita oUsuario = new Cita();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcita", idcita);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oUsuario = new Cita()
                            {
                                IdCita = Convert.ToInt32(dr["IdCita"]),
                                NroDocumento = dr["DocumentoIdentidad"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                Especialidad = dr["Telefono"].ToString(),
                                Fecha = Convert.ToDateTime(dr["FechaRegistro"].ToString())
                            };
                        }

                    }



                    return oUsuario;
                }
                catch (Exception ex)
                {
                    return oUsuario;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcita", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
