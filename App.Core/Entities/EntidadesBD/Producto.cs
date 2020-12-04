using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities
{
    public class Producto : BaseEntidad
    {
        private string Name { get; set; }
        public int precio { get; set; }
        public int Stock { get; set; }
    }
}
