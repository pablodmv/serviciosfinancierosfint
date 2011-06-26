using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using serverFINTPersitencia;
using System.Data;

namespace serverFINT
{

    public class Proveedor
    {
        private int id;
        private String nombre;
        private String direccion;
        private String telefono;
        private tipoProveedor tipo;
        private proveedorPersistente provPersis;
        
        public Proveedor(String pNombre, String pDireccion, String pTelefono, tipoProveedor pTipo)
        {
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.Tipo = pTipo;
            provPersis = new proveedorPersistente();
        }
        public Proveedor()
        {
            provPersis = new proveedorPersistente();

        }

        public tipoProveedor Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Proveedor obtenerObjProveedor(int idProv)
        {

            Proveedor prov = new Proveedor();
            DataSet dsProveedor = new DataSet();
            dsProveedor = provPersis.obtenerProveedoresXid(idProv);
            this.Nombre = dsProveedor.Tables[0].Rows[0]["Nombre"].ToString();
            this.Direccion = dsProveedor.Tables[0].Rows[0]["Direccion"].ToString();
            this.Telefono = dsProveedor.Tables[0].Rows[0]["Telefono"].ToString();
            
            this.Id = int.Parse(dsProveedor.Tables[0].Rows[0]["id"].ToString());
            int tmptipo= int.Parse(dsProveedor.Tables[0].Rows[0]["Tipo"].ToString());
            if (tmptipo == (int)tipoProveedor.Financiera)
            {
                this.Tipo = tipoProveedor.Financiera;

            }
            else if (tmptipo == (int)tipoProveedor.Personal)
            {
                this.Tipo = tipoProveedor.Personal;
            }
            else if (tmptipo == (int)tipoProveedor.Servicios)
            {
                this.Tipo = tipoProveedor.Servicios;
            }


            return this;
        }


      
    }

}