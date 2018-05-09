using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class daOrdenTrabajo
    {
        public List<beOrdenTrabajo> ListarOrdenTrabajo(SqlConnection con)
        {
            List<beOrdenTrabajo> lbeOrdenTrabajo = null;
            SqlCommand cmd = new SqlCommand("SPS_Select_OrdeneTrabajo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

            if (drd != null)
            {
                lbeOrdenTrabajo = new List<beOrdenTrabajo>();
                beOrdenTrabajo obeOrdenTrabajo;

                int pos_Id_OT = drd.GetOrdinal("Id_OT");
                int pos_Numero_OT = drd.GetOrdinal("Numero_OT");
                int pos_Descripcion_OT = drd.GetOrdinal("Descripcion_OT");
                int pos_Fecha_OT = drd.GetOrdinal("Fecha_OT");
                int pos_Estado_OT = drd.GetOrdinal("Estado_OT");


                while (drd.Read())
                {
                    obeOrdenTrabajo = new beOrdenTrabajo();


                    obeOrdenTrabajo.Id_OT = drd.GetInt32(pos_Id_OT);
                    obeOrdenTrabajo.Numero_OT = drd.GetString(pos_Numero_OT);
                    obeOrdenTrabajo.Descripcion_OT = drd.GetString(pos_Descripcion_OT);
                    obeOrdenTrabajo.Fecha_OT = drd.GetDateTime(pos_Fecha_OT);
                    obeOrdenTrabajo.Estado_OT = drd.GetString(pos_Estado_OT);

                    lbeOrdenTrabajo.Add(obeOrdenTrabajo);
                }
                drd.Close();
            }
            cmd.Dispose();
            return (lbeOrdenTrabajo);
        }

        public List<beOrdenTrabajoDetalle> ListarDetalleOT(SqlConnection con, int id_ot)
        {
            List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle = null;
            SqlCommand cmd = new SqlCommand("SPS_Select_OrdeneTrabajoDetalle", con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter par0 = cmd.Parameters.Add("@Id_OT", SqlDbType.Int);
            par0.Direction = ParameterDirection.Input;
            par0.Value = id_ot;

            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

            if (drd != null)
            {
                lbeOrdenTrabajoDetalle = new List<beOrdenTrabajoDetalle>();
                beOrdenTrabajoDetalle obeOrdenTrabajoDetalle;

                int pos_Id_OT = drd.GetOrdinal("Id_Equipo");
                int pos_CantEquipo_OT = drd.GetOrdinal("CantEquipo_OT");

                while (drd.Read())
                {
                    obeOrdenTrabajoDetalle = new beOrdenTrabajoDetalle();
                    obeOrdenTrabajoDetalle.Id_Equipo = drd.GetInt32(pos_Id_OT);
                    obeOrdenTrabajoDetalle.CantEquipo_OT = drd.GetInt32(pos_CantEquipo_OT);
                    lbeOrdenTrabajoDetalle.Add(obeOrdenTrabajoDetalle);
                }
                drd.Close();
            }
            cmd.Dispose();
            return (lbeOrdenTrabajoDetalle);
        }

        public bool RegistrarOT(SqlConnection con, SqlTransaction trx, beOrdenTrabajo obeOrdenTrabajo, List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle, ref string numeroOT)
        {
            bool act = false;
            SqlCommand cmd = new SqlCommand("SPI_Insertar_OrdenTrabajo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Transaction = trx;

            SqlParameter par0 = cmd.Parameters.Add("@Descripcion_OT", SqlDbType.VarChar, 200);
            par0.Direction = ParameterDirection.Input;
            par0.Value = obeOrdenTrabajo.Descripcion_OT;

            SqlParameter par1 = cmd.Parameters.Add("@Estado_OT", SqlDbType.VarChar, 20);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeOrdenTrabajo.Estado_OT;

            SqlParameter par2 = cmd.Parameters.Add("@Id_OT", SqlDbType.Int);
            par2.Direction = ParameterDirection.Output;

            SqlParameter par3 = cmd.Parameters.Add("@NumeroOT", SqlDbType.VarChar, 10);
            par3.Direction = ParameterDirection.Output;


            int i = cmd.ExecuteNonQuery();
            int id_OT = Convert.ToInt32(par2.Value);
            numeroOT = par3.Value.ToString();
            act = true;

            if (i > 0)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SPI_Insertar_DetalleOrdenTrabajo";

                SqlParameter par4 = cmd.Parameters.Add("@Id_OT", SqlDbType.Int);
                par4.Direction = ParameterDirection.Input;


                SqlParameter par5 = cmd.Parameters.Add("@Id_Equipo", SqlDbType.Int);
                par5.Direction = ParameterDirection.Input;


                SqlParameter par6 = cmd.Parameters.Add("@CantEquipo_OT", SqlDbType.Int);
                par6.Direction = ParameterDirection.Input;


                foreach (beOrdenTrabajoDetalle obeOrdenTrabajoDetalle in lbeOrdenTrabajoDetalle)
                {
                    par4.Value = id_OT;
                    par5.Value = obeOrdenTrabajoDetalle.Id_Equipo;
                    par6.Value = obeOrdenTrabajoDetalle.CantEquipo_OT;

                    cmd.ExecuteNonQuery();
                    act = true;
                }
            }
            cmd.Dispose();
            return (act);
        }

        //Cambiar el estado de Programado a Procesado y libera Stock comprometido
        public bool CambiarEstadoOT(SqlConnection con, SqlTransaction trx, beOrdenTrabajo obeOrdenTrabajo, List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle)
        {

            bool act = false;
            SqlCommand cmd = new SqlCommand("SPU_Update_OrdenTrabajo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Transaction = trx;

            SqlParameter par1 = cmd.Parameters.Add("@Estado_OT", SqlDbType.VarChar, 20);
            par1.Direction = ParameterDirection.Input;
            par1.Value = obeOrdenTrabajo.Estado_OT;

            SqlParameter par2 = cmd.Parameters.Add("@Id_OT ", SqlDbType.Int);
            par2.Direction = ParameterDirection.Input;
            par2.Value = obeOrdenTrabajo.Id_OT;
        
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SPU_Update_LiberarStockComprometidoEquipo";

                SqlParameter par3 = cmd.Parameters.Add("@Id_Equipo", SqlDbType.Int);
                par3.Direction = ParameterDirection.Input;


                SqlParameter par4 = cmd.Parameters.Add("@ID_CantidadLiberar", SqlDbType.Int);
                par4.Direction = ParameterDirection.Input;


                foreach (beOrdenTrabajoDetalle obeOrdenTrabajoDetalle in lbeOrdenTrabajoDetalle)
                {
                    par3.Value = obeOrdenTrabajoDetalle.Id_Equipo;
                    par4.Value = obeOrdenTrabajoDetalle.CantEquipo_OT;
                    cmd.ExecuteNonQuery();
                    act = true;
                }
            }
            cmd.Dispose();
            return (act);
        }
    }
}
