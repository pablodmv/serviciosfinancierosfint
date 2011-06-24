using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace serverFINTPersitencia
{
    public class cuentaPersistente : Persistente
    {

        public cuentaPersistente()
        {

        }



        public Boolean ingresarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario)
        {

            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO CUENTAS (NumeroCuenta, Descripcion, Saldo,idProveedor,idUsuario) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5)";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = numero;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = descripcion;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Decimal).Value = saldo;
                sqlCom.Parameters.Add("@Val4", SqlDbType.Int).Value = idProveedor;
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = idUsuario;
                sqlCom.Connection = dbConnection;
                dbConnection.Open();
                sqlCom.ExecuteNonQuery();
                dbConnection.Close();
                         return true;
            }
            catch (SqlException e)
            {
                return false                ;

            }
            return false;

        }


        public DataSet obtenerCuentaPorUsuario(int idUsuario)
        {
            DataSet dsCuentas = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from CUENTAS WHERE idUsuario=" + idUsuario, conn);

                da.Fill(dsCuentas, "Cuentas");
                return dsCuentas;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dsCuentas;
        }

    }
}
