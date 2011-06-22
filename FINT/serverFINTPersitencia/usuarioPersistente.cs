using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace serverFINTPersitencia
{
   public class usuarioPersistente : Persistente
    {

       public usuarioPersistente()
       {

       }


       public int altaUsuario(String nombre, String login, String passwd, int tipo)
       {

           try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
              //  SqlCommand sqlCom = new SqlCommand("INSERT INTO USUARIOS (Nombre, Login, Password,Tipo) VALUES (@Val1, @Val2, @Val3, @Val4)", dbConnection);
              
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO USUARIOS (Nombre, Login, Password,Tipo) VALUES (@Val1, @Val2, @Val3, @Val4)";
                sqlCom.Parameters.Add("@Val1",SqlDbType.Text).Value = nombre;
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = login;
                sqlCom.Parameters.Add("@Val3", SqlDbType.Text).Value = passwd;
                sqlCom.Parameters.Add("@Val4", SqlDbType.Int).Value = tipo;
                sqlCom.Connection = dbConnection;
                dbConnection.Open();
                sqlCom.ExecuteNonQuery();
                dbConnection.Close();

                //SqlDataAdapter dbDataAdapter = new SqlDataAdapter();
                //dbDataAdapter.InsertCommand = sqlCom;

                //DataSet dsUsuarios = new DataSet();

                //dbDataAdapter.Update(dsUsuarios,"USUARIOS"); 
                ////dbDataAdapter.Fill(dsUsuarios,"USUARIOS");
                return 0;
            }
            catch (SqlException e)
            {
                return e.Class;
                
            }
            //return false;

       }

       public DataSet consultaUsuario(String login, String pwd)
       {
           SqlConnection conn = new SqlConnection(this.conn);
           SqlDataAdapter da = new SqlDataAdapter("select * from USUARIOS WHERE LOGIN='"+ login +"' AND PASSWORD='"+pwd+"'", conn);
           DataSet dsUsuario = new DataSet();
           da.Fill(dsUsuario, "Customers");
           return dsUsuario;

       }



    }
}
