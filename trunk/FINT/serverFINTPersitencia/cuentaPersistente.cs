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
                return false;

            }
            return true;

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


        public DataSet obtenerObjCuenta(int idcuenta)
        {
            DataSet dsCuentas = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from CUENTAS WHERE id=" + idcuenta, conn);

                da.Fill(dsCuentas, "Cuentas");
                return dsCuentas;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dsCuentas;
        }

        public Boolean modificarCuenta(String numero, String descripcion, Decimal saldo, int idProveedor, int idUsuario, int idcuenta)
        {

            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "UPDATE CUENTAS SET NumeroCuenta=@VAL1, Descripcion=@VAL2, Saldo=@VAL3,idProveedor=@VAL4,idUsuario=@VAL5 WHERE ID=@VAL6";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = numero;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = descripcion;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Decimal).Value = saldo;
                sqlCom.Parameters.Add("@Val4", SqlDbType.Int).Value = idProveedor;
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = idUsuario;
                sqlCom.Parameters.Add("@Val6", SqlDbType.Int).Value = idcuenta;
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
            return true;

        }

    }
}
