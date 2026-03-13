using System;
using System.Collections.Generic;
using System.Text;

namespace TextileSystem.Models
{
    public class Proveedor
    {

        public Int64? prov_id { get; set; }
        public string prov_nombre { get; set; }
        public string prov_direccion { get; set; }
        public string prov_telefonos { get; set; }
        public string prov_observaciones { get; set; }
        public bool? prov_status { get; set; }

    }
}
