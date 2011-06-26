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

        public Boolean ingresarGasto(String numero, String concepto, Decimal monto, String vencimiento, int estado, int idUsuario, int idcuenta)
        {

            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO GASTOS (NumFactura, Concepto, Monto,Vencimiento,Estado, idusuario,idcuenta) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5, @Val6,@VAL7)";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = numero;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = concepto;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Decimal).Value = monto;
                sqlCom.Parameters.Add("@Val4", SqlDbType.DateTime).Value = DateTime.Parse(vencimiento);
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = estado;
                sqlCom.Parameters.Add("@Val6", SqlDbType.Int).Value = idUsuario;
                sqlCom.Parameters.Add("@Val7", SqlDbType.Int).Value = idcuenta;
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


        public DataSet obtenerGastosPorUsuario(int idUsuario)
        {
            DataSet dsGastos = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from GASTOS WHERE idUsuario=" + idUsuario + " AND Estado=0", conn);
               
                da.Fill(dsGastos, "Gastos2");
                return dsGastos;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dsGastos;
        }

        public DataSet obtenerGastosPorId(int idGasto)
        {
            DataSet dsGastos = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(this.conn);
                SqlDataAdapter da = new SqlDataAdapter("select * from GASTOS WHERE id=" + idGasto, conn);

                da.Fill(dsGastos, "Gastos");
                return dsGastos;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Class);
            }
            return dsGastos;
        }

        public Boolean modificarGasto(int id, String numero, String concepto, Decimal monto, String vencimiento, int estado)
        {

            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "UPDATE USUARIOS SET NumFactura=@VAL1,Concepto=@VAL2,Monto=@VAL3,Vencimiento=@VAL4,Estado=@VAL5 WHERE ID=@VAL6";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = numero;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = concepto;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Decimal).Value = monto;
                sqlCom.Parameters.Add("@Val4", SqlDbType.DateTime).Value = DateTime.Parse(vencimiento);
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = estado;
                sqlCom.Parameters.Add("@Val6", SqlDbType.Int).Value = id;
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




        public bool modificarEstadoGasto(int idgasto, int estado)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "UPDATE GASTOS SET Estado=@VAL1 WHERE ID=@VAL2";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Int).Value = estado;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Int).Value = idgasto;
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

     
    }
}
