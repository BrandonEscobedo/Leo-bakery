using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.negocio
{
    public class ndv
    {
        public int id_detalle_venta { get; set; }
        public int idventa { get; set; }
        public int id_producto { get; set; }
        public double cantidad {get;set;}
        public  double precio_u {get;set;}
        public string  moneda {get;set;}
        public double total_pagar  {get;set;}
        public string unidad_med {get;set;}
        public  double  cantidad_most {get;set;}
        public string estado {get;set;}
        public  string descripcion {get;set;}
        public string codigo  {get;set;}
        public  string tipo_venta {get;set;}
        public  string usa_inv {get;set;}
        public  double costo{get;set;}
        public  double ganancia {get;set;}
       
    }
}
