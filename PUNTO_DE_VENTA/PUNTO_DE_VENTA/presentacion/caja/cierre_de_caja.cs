using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;

namespace PUNTO_DE_VENTA.presentacion.caja
{
    public partial class cierre_de_caja : Form
    {
        public cierre_de_caja()
        {
            InitializeComponent();
        }
        int idcaja;
        DateTime fecha_final = DateTime.Now;
        DateTime fecha_inical;
        double saldo_inicial_caja;
        double efectivo_tl;
        double tarjeta_tl;
        double credito_tl;
        double total_caja;
        public static double dinero_turno;
        public static double ingresos;
        public static double egresos;
        private void cierre_de_caja_Load(object sender, EventArgs e)
        {
            mostrar_caja_abierta();
            lbl_inicio.Text =Convert.ToString( fecha_inical);
            lbl_cierre.Text = Convert.ToString(fecha_final);
            lbl_dinero_inicial.Text = Convert.ToString(saldo_inicial_caja);
            datos.procedimientos_reutilizables.mostrar_ventas_efectivo_turno(idcaja, fecha_inical, fecha_final, ref efectivo_tl);
            datos.procedimientos_reutilizables.mostrar_ventas_tarjeta_turno(idcaja, fecha_inical, fecha_final, ref tarjeta_tl);
            datos.procedimientos_reutilizables.mostrar_ventas_credito_turno(idcaja, fecha_inical, fecha_final, ref credito_tl);
            lbl_efectivo_tt.Text = Convert.ToString(efectivo_tl);
            lbl_tarjeta.Text = Convert.ToString(tarjeta_tl);
            lbl_credito.Text = Convert.ToString(credito_tl);
            calcular_total();
             
        }
        private void calcular_total()
        {
            total_caja = efectivo_tl + tarjeta_tl + credito_tl;
            lbl_dinero_total.Text = total_caja.ToString();
            ingresos = saldo_inicial_caja + total_caja;
            egresos = 0;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void mostrar_caja_abierta()
        {
            DataTable dt = new DataTable();
            datos.cerrar_abrir_caja.mostrar_cierre_de_caja_pendiente(ref dt);
            foreach (DataRow dr in dt.Rows)
            {
                idcaja = Convert.ToInt32(dr["id_caja"]);
                fecha_inical = Convert.ToDateTime(dr["fecha_inicio"]);
                saldo_inicial_caja = Convert.ToDouble(dr["saldo_en_caja"]);
            }
            
        }
        private void btn_cerrar_turno_Click(object sender, EventArgs e)
        {
            terminar_turno frm = new terminar_turno();
            dinero_turno = Convert.ToDouble(lbl_dinero_total.Text);
            frm.ShowDialog();
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        
        }
    }
}
