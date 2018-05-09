using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Configuration;
using CapaDatos;

namespace CapaNegocio
{
    public class brOrdenTrabajo
    {
        public List<beOrdenTrabajo> ListarOrdenTrabajo(ref string msgError)
        {
            List<beOrdenTrabajo> lbeOrdenTrabajo = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    daOrdenTrabajo odaOrdenTrabajo = new daOrdenTrabajo();
                    lbeOrdenTrabajo = odaOrdenTrabajo.ListarOrdenTrabajo(con);
                }
                catch (SqlException sqlex)
                {
                    msgError = sqlex.Message;
                }
                catch (Exception ex)
                {
                    msgError = ex.Message;
                }
            }
            return (lbeOrdenTrabajo);
        }

        public List<beOrdenTrabajoDetalle> ListarDetalleOT(int id_ot,ref string msgError)
        {
            List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    daOrdenTrabajo odaOrdenTrabajo = new daOrdenTrabajo();
                    lbeOrdenTrabajoDetalle = odaOrdenTrabajo.ListarDetalleOT(con, id_ot);
                }
                catch (SqlException sqlex)
                {
                    msgError = sqlex.Message;
                }
                catch (Exception ex)
                {
                    msgError = ex.Message;
                }
            }
            return (lbeOrdenTrabajoDetalle);
        }

        public bool RegistrarOT( beOrdenTrabajo obeOrdenTrabajo, List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle, ref string numeroOT, ref string msgError)
        {
            bool act = false;
            SqlTransaction trx = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    trx = con.BeginTransaction();
                    daOrdenTrabajo odaOrdenTrabajo = new daOrdenTrabajo();
                    act = odaOrdenTrabajo.RegistrarOT(con, trx, obeOrdenTrabajo, lbeOrdenTrabajoDetalle, ref numeroOT);

                    if (act) trx.Commit(); else trx.Rollback();

                }
                catch (SqlException sqlex)
                {
                    msgError = sqlex.Message;
                }
                catch (Exception ex)
                {
                    msgError = ex.Message;
                }
                return act;
            }
        }

        public bool CambiarEstadoOT( beOrdenTrabajo obeOrdenTrabajo, List<beOrdenTrabajoDetalle> lbeOrdenTrabajoDetalle, ref string msgError)
        {
            bool act = false;
            SqlTransaction trx = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    trx = con.BeginTransaction();
                    daOrdenTrabajo odaOrdenTrabajo = new daOrdenTrabajo();
                    act = odaOrdenTrabajo.CambiarEstadoOT(con, trx, obeOrdenTrabajo, lbeOrdenTrabajoDetalle);

                    if (act) trx.Commit(); else trx.Rollback();

                }
                catch (SqlException sqlex)
                {
                    msgError = sqlex.Message;
                }
                catch (Exception ex)
                {
                    msgError = ex.Message;
                }
                return act;
            }
        }
    }
}
