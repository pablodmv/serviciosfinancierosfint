using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace serverFINT
{

    public class Proveedor
    {
        private int codProveedor;

      
        private String nombre;
        private String direccion;
        private String telefono;
        private tipoProveedor tipoProveedor;
        
        public Proveedor(String pNombre, String pDireccion, String pTelefono, tipoProveedor pTipo)
        {
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.TipoProveedor = pTipo;
        }
        public Proveedor()
        {

        }

        public tipoProveedor TipoProveedor
        {
            get { return tipoProveedor; }
            set { tipoProveedor = value; }
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
        public int CodProveedor
        {
            get { return codProveedor; }
            set { codProveedor = value; }
        }

      
    }

}