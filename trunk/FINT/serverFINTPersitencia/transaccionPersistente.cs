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



        public Boolean ingresarTransaccion(String pconcepto,Decimal monto,int tipo,String fecha,int idgasto,int estado,int idcuenta,int idcuentadestino)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO TRANSACCIONES (Concepto, Monto, Tipo,Fecha,idGasto,Estado,idCuenta,idCuentaDestino) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5, @Val6, @Val7, @Val8)";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = pconcepto;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Decimal).Value = monto;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Int).Value = tipo;
                sqlCom.Parameters.Add("@Val4", SqlDbType.DateTime).Value = DateTime.Parse(fecha);
                sqlCom.Parameters.Add("@Val5", SqlDbType.Int).Value = idgasto;
                sqlCom.Parameters.Add("@Val6", SqlDbType.Int).Value = estado;
                sqlCom.Parameters.Add("@Val7", SqlDbType.Int).Value = idcuenta;
                sqlCom.Parameters.Add("@Val8", SqlDbType.Int).Value = idcuentadestino;
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

        

        public void obtenerTransaccionXcuenta(int idcuenta)
        {
        }



















        //public int altaTransaccion(Object param )
        //{

        //    try
        //    {
        //        SqlConnection dbConnection = new SqlConnection(this.conn);
        //        //  SqlCommand sqlCom = new SqlCommand("INSERT INTO USUARIOS (Nombre, Login, Password,Tipo) VALUES (@Val1, @Val2, @Val3, @Val4)", dbConnection);

        //        SqlCommand sqlCom = new SqlCommand();
        //        sqlCom.CommandType = CommandType.Text;
        //        sqlCom.CommandText = "INSERT INTO USUARIOS (Nombre, Login, Password,Tipo) VALUES (@Val1, @Val2, @Val3, @Val4)";
        //        sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = (Usuario) param.Nombre;
        //        sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = login;
        //        sqlCom.Parameters.Add("@Val3", SqlDbType.Text).Value = passwd;
        //        sqlCom.Parameters.Add("@Val4", SqlDbType.Int).Value = tipo;
        //        sqlCom.Connection = dbConnection;
        //        dbConnection.Open();
        //        sqlCom.ExecuteNonQuery();
        //        dbConnection.Close();

        //        //SqlDataAdapter dbDataAdapter = new SqlDataAdapter();
        //        //dbDataAdapter.InsertCommand = sqlCom;

        //        //DataSet dsUsuarios = new DataSet();

        //        //dbDataAdapter.Update(dsUsuarios,"USUARIOS"); 
        //        ////dbDataAdapter.Fill(dsUsuarios,"USUARIOS");
               

        //        return 0;
        //    }
        //    catch (SqlException e)
        //    {
        //        return e.Class;

        //    }
        //    //return false;

        //}

        //public DataSet consultaUsuario(String login, String pwd)
        //{
        //    SqlConnection conn = new SqlConnection(this.conn);
        //    SqlDataAdapter da = new SqlDataAdapter("select * from USUARIOS WHERE LOGIN='" + login + "' AND PASSWORD='" + pwd + "'", conn);
        //    DataSet dsUsuario = new DataSet();
        //    da.Fill(dsUsuario, "Customers");
        //    return dsUsuario;
        //}

        //public Boolean eliminarUsuario(int id)
        //{
        //    try
        //    {
        //        SqlConnection dbConnection = new SqlConnection(this.conn);
        //        SqlCommand sqlCom = new SqlCommand();
        //        sqlCom.CommandType = CommandType.Text;
        //        sqlCom.CommandText = "DELETE FROM USUARIOS WHERE ID=@Val1";
        //        sqlCom.Parameters.Add("@Val1", SqlDbType.Int).Value = id;
        //        sqlCom.Connection = dbConnection;
        //        dbConnection.Open();
        //        sqlCom.ExecuteNonQuery();
        //        dbConnection.Close();
        //        return true;
        //    }
        //    catch (SqlException e)
        //    {
        //        //return e.Class;
        //        //TODO: Log

        //    }
        //    return false;


        //}

        //public Boolean modificarUsuario(String nombre, String login, String passwd, int tipo)
        //{

        //    try
        //    {
        //        SqlConnection dbConnection = new SqlConnection(this.conn);
        //        SqlCommand sqlCom = new SqlCommand();
        //        sqlCom.CommandType = CommandType.Text;
        //        sqlCom.CommandText = "UPDATE USUARIOS SET Nombre=@VAL1,Password=@VAL2,Tipo=@VAL3";
        //        sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = nombre;
        //        sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = passwd;
        //        sqlCom.Parameters.Add("@Val3", SqlDbType.Int).Value = tipo;
        //        sqlCom.Connection = dbConnection;
        //        dbConnection.Open();
        //        sqlCom.ExecuteNonQuery();
        //        dbConnection.Close();

        //        return true;
        //    }
        //    catch (SqlException e)
        //    {
        //        //TODO:log

        //    }
        //    return false;

        //}








    }
}
