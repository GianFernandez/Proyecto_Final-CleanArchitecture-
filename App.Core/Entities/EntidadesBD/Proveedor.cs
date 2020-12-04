using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities
{
    public class Proveedor : BaseEntidad
    {
        private string proveedor;

        public string GetProveedor()
        {
            return proveedor;
        }

        public void SetProveedor(string value)
        {
            proveedor = value;
        }

        public string Pedidos { get; set; }
        public string Almacen { get; set; }
    }
}
