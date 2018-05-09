using System;
using System.Collections.Generic;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class daEquipo
    {
        public List<beEquipo> ListarEquipo(SqlConnection con)
        {
            List<beEquipo> lbeEquipo = null;
            SqlCommand cmd = new SqlCommand("SPS_Select_Equipo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

            if (drd != null)
            {
                lbeEquipo = new List<beEquipo>();
                beEquipo obeEquipo;

                int pos_Id_Equipo = drd.GetOrdinal("Id_Equipo");
                int pos_Descripcion_Equipo = drd.GetOrdinal("Descripcion_Equipo");
                int pos_Id_Marca = drd.GetOrdinal("Id_Marca");
                int pos_Modelo_Equipo = drd.GetOrdinal("Modelo_Equipo");
                int pos_Serie_Equipo = drd.GetOrdinal("Serie_Equipo");
                int pos_CantBase_Equipo = drd.GetOrdinal("CantBase_Equipo");
                int pos_CantComprometida_Equipo = drd.GetOrdinal("CantComprometida_Equipo");
                int pos_CantDisponible_Equipo = drd.GetOrdinal("CantDisponible_Equipo");
                int pos_Descripcion_Marca = drd.GetOrdinal("Descripcion_Marca");
                int pos_Activo_Equipo = drd.GetOrdinal("Activo_Equipo");

                while (drd.Read())
                {
                    obeEquipo = new beEquipo();
                    obeEquipo.Id_Equipo = drd.GetInt32(pos_Id_Equipo);
                    obeEquipo.Descripcion_Equipo = drd.GetString(pos_Descripcion_Equipo);
                    obeEquipo.Id_Marca = drd.GetInt32(pos_Id_Marca);
                    obeEquipo.Modelo_Equipo = drd.GetString(pos_Modelo_Equipo);
                    obeEquipo.Serie_Equipo = drd.GetString(pos_Serie_Equipo);
                    obeEquipo.CantBase_Equipo = drd.GetInt32(pos_CantBase_Equipo);
                    obeEquipo.CantComprometida_Equipo = drd.GetInt32(pos_CantComprometida_Equipo);
                    obeEquipo.CantDisponible_Equipo = drd.GetInt32(pos_CantDisponible_Equipo);
                    obeEquipo.Descripcion_Marca = drd.GetString(pos_Descripcion_Marca);
                    bool estado = drd.GetBoolean(pos_Activo_Equipo);
                    if (estado) obeEquipo.Estado_Equipo = "Activo"; else obeEquipo.Estado_Equipo = "Anulado";
                    lbeEquipo.Add(obeEquipo);
                }
                drd.Close();
            }
            cmd.Dispose();
            return (lbeEquipo);
        }

        public bool RegistrarEquipo(SqlConnection con, SqlTransaction trx, beEquipo obeEquipo)
        {

            bool act = false;
            SqlCommand cmd = new SqlCommand("SPI_Insert_Equipo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Transaction = trx;

            SqlParameter par1 = cmd.Parameters.Add("@Descripcion_Equipo", SqlDbType.VarChar, 100);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeEquipo.Descripcion_Equipo;

            SqlParameter par2 = cmd.Parameters.Add("@Id_Marca ", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeEquipo.Id_Marca;

            SqlParameter par3 = cmd.Parameters.Add("@Modelo_Equipo", SqlDbType.VarChar, 50);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeEquipo.Modelo_Equipo;

            SqlParameter par4 = cmd.Parameters.Add("@Serie_Equipo", SqlDbType.VarChar, 50);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeEquipo.Serie_Equipo;

            SqlParameter par5 = cmd.Parameters.Add("@CantBase_Equipo", SqlDbType.Int);
            par5.Direction = ParameterDirection.Input;
            par5.Value = obeEquipo.CantBase_Equipo;
            int i = cmd.ExecuteNonQuery();
            act = true;
            cmd.Dispose();
            return (act);
        }

        public bool ActualizarEquipo(SqlConnection con, SqlTransaction trx, beEquipo obeEquipo)
        {

            bool act = false;
            SqlCommand cmd = new SqlCommand("SPU_Update_Equipo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Transaction = trx;

            SqlParameter par0 = cmd.Parameters.Add("@Id_Equipo", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeEquipo.Id_Equipo;


            SqlParameter par1 = cmd.Parameters.Add("@Descripcion_Equipo", SqlDbType.VarChar, 100);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeEquipo.Descripcion_Equipo;

            SqlParameter par2 = cmd.Parameters.Add("@Id_Marca ", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeEquipo.Id_Marca;

            SqlParameter par3 = cmd.Parameters.Add("@Modelo_Equipo", SqlDbType.VarChar, 50);
            par3.Direction = ParameterDirection.Input;
            par3.Value = obeEquipo.Modelo_Equipo;

            SqlParameter par4 = cmd.Parameters.Add("@Serie_Equipo", SqlDbType.VarChar, 50);
            par4.Direction = ParameterDirection.Input;
            par4.Value = obeEquipo.Serie_Equipo;

            SqlParameter par5 = cmd.Parameters.Add("@CantBase_Equipo", SqlDbType.Int);
            par5.Direction = ParameterDirection.Input;
            par5.Value = obeEquipo.CantBase_Equipo;
            int i = cmd.ExecuteNonQuery();
            act = true;
            cmd.Dispose();
            return (act);
        }

        public bool CambiarEstadoEquipo(SqlConnection con, SqlTransaction trx, int id_equipo, bool estado)
        {

            bool act = false;
            SqlCommand cmd = new SqlCommand("SPU_Cambiar_Estado", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Transaction = trx;

            SqlParameter par0 = cmd.Parameters.Add("@Id_Equipo", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = id_equipo;


            SqlParameter par1 = cmd.Parameters.Add("@Estado", SqlDbType.Bit);
            par1.Direction = ParameterDirection.Input;
            par1.Value = estado;

            int i = cmd.ExecuteNonQuery();
            act = true;
            cmd.Dispose();
            return (act);
        }

        public List<beEquipo> ListarEquipoBusqueda(SqlConnection con)
        {
            List<beEquipo> lbeEquipo = null;
            SqlCommand cmd = new SqlCommand("SPS_Select_Equipo_Busqueda", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

            if (drd != null)
            {
                lbeEquipo = new List<beEquipo>();
                beEquipo obeEquipo;

                int pos_Id_Equipo = drd.GetOrdinal("Id_Equipo");
                int pos_Descripcion_Equipo = drd.GetOrdinal("Descripcion_Equipo");
                int pos_Modelo_Equipo = drd.GetOrdinal("Modelo_Equipo");
                int pos_Serie_Equipo = drd.GetOrdinal("Serie_Equipo");
                int pos_CantDisponible_Equipo = drd.GetOrdinal("CantDisponible_Equipo");
                int pos_Descripcion_Marca = drd.GetOrdinal("Descripcion_Marca");
                while (drd.Read())
                {
                    obeEquipo = new beEquipo();
                    obeEquipo.Id_Equipo = drd.GetInt32(pos_Id_Equipo);
                    obeEquipo.Descripcion_Equipo = drd.GetString(pos_Descripcion_Equipo);
                    obeEquipo.Modelo_Equipo = drd.GetString(pos_Modelo_Equipo);
                    obeEquipo.Serie_Equipo = drd.GetString(pos_Serie_Equipo);
                    obeEquipo.CantDisponible_Equipo = drd.GetInt32(pos_CantDisponible_Equipo);
                    obeEquipo.Descripcion_Marca = drd.GetString(pos_Descripcion_Marca);
                    lbeEquipo.Add(obeEquipo);
                }
                drd.Close();
            }
            cmd.Dispose();
            return (lbeEquipo);
        }
    }
}
