using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.negocio
{
     public class cerrar_turno
    {
        public int id_cierre_caja { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime fecha_cierre { get; set; }
        public double ingresos { get; set; }
        public double egresos { get; set; }
        public double saldo_en_caja { get; set; }
        public int id_usuario { get; set; }
        public double total_calculado { get; set; }
        public double total_real { get; set; }
        public string  estado { get; set; }
        public double  diferencia { get; set; }
        public int idcaja { get; set; }
    }
}
