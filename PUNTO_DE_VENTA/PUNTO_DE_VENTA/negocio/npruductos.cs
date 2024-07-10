using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.negocio
{
    public class npruductos
    {
        public int idproducto  {get;set; }
        public string descripcion {get;set; }
        public string  imagen {get;set; }
        public  int idgrupo {get;set; }
        public string usa_inv {get;set; }
        public string stock {get;set; }
        public double precio_c {get;set; }
        public string fecha_ven {get;set; }
        public double precio_v {get;set; }
        public  string codigo {get;set; }
        public string tipo_venta {get;set; }
        public string impuesto {get;set; }
        public double stock_m {get;set; }
        public double precio_m {get;set; }
        public double sub_total_p_venta {get;set; }
        public double sub_total_p_mayoreo {get;set; }
        public  double a_partir_pm{get;set; }

    }
}
