using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace serverFINTPersitencia
{
   public class proveedorPersistente : Persistente
    {
        public proveedorPersistente()
        {

        }

        public DataSet obtenerProveedores()
        {
            DataSet dsProveedores = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from PROVEEDORES", conn);
               
                da.Fill(dsProveedores, "Proveedores");
                return dsProveedores;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);                
            }
            return dsProveedores;
        }



    }
}
