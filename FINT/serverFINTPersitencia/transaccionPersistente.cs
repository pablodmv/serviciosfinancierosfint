using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace serverFINTPersitencia
{
    public class transaccionPersistente : Persistente
    {



        public Boolean ingresarTransaccion(String pconcepto,Decimal monto,int tipo,String fecha,int idgasto,int estado,int idcuenta,int idcuentadestino,String comprobante)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO TRANSACCIONES (Concepto, Monto, Tipo,Fecha,idGasto,Estado,idCuenta,idCuentaDestino,Comprobante) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5, @Val6, @Val7, @Val8,@VAL9)";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = pconcepto;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Decimal).Value = monto;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Int).Value = tipo;
                sqlCom.Parameters.Add("@Val4", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = idgasto;
                sqlCom.Parameters.Add("@Val6", SqlDbType.Int).Value = estado;
                sqlCom.Parameters.Add("@Val7", SqlDbType.Int).Value = idcuenta;
                sqlCom.Parameters.Add("@Val8", SqlDbType.Int).Value = idcuentadestino;
                sqlCom.Parameters.Add("@Val9", SqlDbType.Text).Value = comprobante;
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



        }

        public Boolean modificarTransaccion(int id,String pconcepto, Decimal monto, int tipo, String fecha, int idgasto, int estado, int idcuenta, int idcuentadestino, String comprobante)
        {

            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "UPDATE TRANSACCIONES SET Concepto=@VAL1,Monto=@VAL2,Tipo=@VAL3,Fecha=@VAL4,idGasto=@VAL5,Estado=@VAL6,idCuenta=@VAL7,idCuentaDestino=@VAL8,Comprobante=@VAL9 WHERE NumTransac=@VAL10";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = pconcepto;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Decimal).Value = monto;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Int).Value = tipo;
                sqlCom.Parameters.Add("@Val4", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = idgasto;
                sqlCom.Parameters.Add("@Val6", SqlDbType.Int).Value = estado;
                sqlCom.Parameters.Add("@Val7", SqlDbType.Int).Value = idcuenta;
                sqlCom.Parameters.Add("@Val8", SqlDbType.Int).Value = idcuentadestino;
                sqlCom.Parameters.Add("@Val9", SqlDbType.Text).Value = comprobante;
                sqlCom.Parameters.Add("@Val10", SqlDbType.Int).Value = id;
                sqlCom.Connection = dbConnection;
                dbConnection.Open();
                sqlCom.ExecuteNonQuery();
                dbConnection.Close();

                return true;
            }
            catch (SqlException e)
            {
                //TODO:log

            }
            return false;
        }


        public DataSet obtenerTransaccionXcuenta(int idcuenta)
        {

            DataSet dstransacc = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from TRANSACCIONES WHERE idCuenta=" + idcuenta +" AND ESTADO=0", conn);

                da.Fill(dstransacc, "Transacciones");
                return dstransacc;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dstransacc;
        }

        public DataSet obtenerTransaccionPendiente()
        {

            DataSet dstransacc = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from TRANSACCIONES WHERE ESTADO=0", conn);

                da.Fill(dstransacc, "Transacciones");
                return dstransacc;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dstransacc;
        }
        public DataSet obtenerTransaccionXid(int idtransac)
        {

            DataSet dstransacc = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from TRANSACCIONES WHERE NumTransac=" + idtransac , conn);

                da.Fill(dstransacc, "Transacciones");
                return dstransacc;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dstransacc;





        }
















    }
}
