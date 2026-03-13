namespace TextileSystem.Models
{
    public class Cliente
    {

        public Int64? cl_id { get; set; }
        public string cl_nombre { get; set; }

        public string cl_direccion { get; set; }

        public string cl_calle { get; set; }
        public string cl_numExt { get; set; }
        public string cl_numInt { get; set; }
        public string cl_colonia { get; set; }
        public string cl_delegacion { get; set; }
        public string cl_estado { get; set; }
        public string cl_cp { get; set; }

        public string cl_telefonos { get; set; }
        public string cl_observaciones { get; set; }
        public bool? cl_status { get; set; }


    }
}
