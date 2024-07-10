using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.negocio
{
   public class ncreditos_pagar
    {
        public int tid_credito { get; set; }
    public  string descripcion { get;set; }
        public DateTime fecha_registro { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public double total { get; set; }
        public double saldo { get; set; }
        public string estado { get; set; }
        public int idcaja { get; set; }
        public int idproveedor { get; set; }
}
}
