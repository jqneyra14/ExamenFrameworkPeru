using System;
using System.Collections.Generic;
using CapaEntidades;
using System.Data.SqlClient;
using System.Configuration;
using CapaDatos;

namespace CapaNegocio
{
    public class brEquipo
    {
        public List<beEquipo> ListarEquipo(ref string msgError)
        {
            List<beEquipo> lbeEquipo = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    daEquipo odaEquipo = new daEquipo();
                    lbeEquipo = odaEquipo.ListarEquipo(con);
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
            return (lbeEquipo);
        }

        public bool RegistrarEquipo(beEquipo obeEquipo, ref string msgError)
        {
            bool act = false;
            SqlTransaction trx = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    trx = con.BeginTransaction();
                    daEquipo odaEquipo = new daEquipo();
                    act = odaEquipo.RegistrarEquipo(con, trx, obeEquipo);

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

        public bool ActualizarEquipo(beEquipo obeEquipo, ref string msgError)
        {
            bool act = false;
            SqlTransaction trx = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    trx = con.BeginTransaction();
                    daEquipo odaEquipo = new daEquipo();
                    act = odaEquipo.ActualizarEquipo(con, trx, obeEquipo);

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

        public bool CambiarEstadoEquipo(int id_equipo, bool estado, ref string msgError)
        {
            bool act = false;
            SqlTransaction trx = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    trx = con.BeginTransaction();
                    daEquipo odaEquipo = new daEquipo();
                    act = odaEquipo.CambiarEstadoEquipo(con, trx, id_equipo, estado);

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

        public List<beEquipo> ListarEquipoBusqueda(ref string msgError)
        {
            List<beEquipo> lbeEquipo = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    daEquipo odaEquipo = new daEquipo();
                    lbeEquipo = odaEquipo.ListarEquipoBusqueda(con);
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
            return (lbeEquipo);
        }

    }
}
