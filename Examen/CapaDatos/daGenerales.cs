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
   public class daGenerales
    {
        public List<beMarca> ListarMarca(SqlConnection con)
        {
            List<beMarca> lbeMarca = null;
            SqlCommand cmd = new SqlCommand("SPS_Select_Marca", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.SingleResult);

            if (drd != null)
            {
                lbeMarca = new List<beMarca>();
                beMarca obeMarca;

                int pos_Id_Marca = drd.GetOrdinal("Id_Marca");
                int pos_Descripcion = drd.GetOrdinal("Descripcion_Marca");

                while (drd.Read())
                {
                    obeMarca = new beMarca();
                    obeMarca.Id_Marca = drd.GetInt32(pos_Id_Marca);
                    obeMarca.Descripcion_Marca = drd.GetString(pos_Descripcion);

                    lbeMarca.Add(obeMarca);
                }
                drd.Close();
            }
            cmd.Dispose();
            return (lbeMarca);
        }
    }
}
