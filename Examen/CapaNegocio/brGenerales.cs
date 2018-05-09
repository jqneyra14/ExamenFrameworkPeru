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
    public class brGenerales
    {
        public List<beMarca> ListarMarca(ref string msgError)
        {
            List<beMarca> lbeMarca = null;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                try
                {
                    con.Open();
                    daGenerales odaGenerales = new daGenerales();
                    lbeMarca = odaGenerales.ListarMarca(con);
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
            return (lbeMarca);
        }
    }
}
