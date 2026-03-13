using System;
using System.Collections.Generic;
using System.Text;

namespace TextileSystem.Models
{
    public class Producto
    {

        public Int64 prod_id { get; set; }
        public string prod_nombre { get; set; }

        public decimal? prod_precioMen { get; set; }
        public decimal? prod_precioRollo { get; set; }
        public decimal? prod_precioMay { get; set; }

        public decimal? prod_precioMenT { get; set; }
        public decimal? prod_precioRolloT { get; set; }
        public decimal? prod_precioMayT { get; set; }

        public decimal? prod_costoprom { get; set; }
        public decimal? prod_ultimocosto { get; set; }
        public decimal? prod_total { get; set; }
        public string prod_utlidadPorc { get; set; }
        public string prod_utlidadPorcUc { get; set; }

        public bool prod_cap { get; set; }
        public bool prod_fashion { get; set; }

        public bool? prod_status { get; set; }

        public decimal? inv_cantidad { get; set; }

    }
}
