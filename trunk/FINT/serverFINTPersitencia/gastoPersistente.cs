using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace serverFINTPersitencia
{
    public class gastoPersistente :Persistente
    {
        

        public gastoPersistente()
        {
           

        }

        public Boolean ingresarGasto(String numero, String concepto, Decimal monto, String vencimiento, int estado)
        {

            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO GASTOS (NumFactura, Concepto, Monto,Vencimiento,Estado) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5)";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = numero;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = concepto;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Decimal).Value = monto;
                sqlCom.Parameters.Add("@Val4", SqlDbType.DateTime).Value = DateTime.Parse(vencimiento);
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = estado;
                sqlCom.Connection = dbConnection;
                dbConnection.Open();
                sqlCom.ExecuteNonQuery();
                dbConnection.Close();
                return true;
            }
            catch (SqlException e)
            {
                return false;

            }
            return false;

        }





    }
}
