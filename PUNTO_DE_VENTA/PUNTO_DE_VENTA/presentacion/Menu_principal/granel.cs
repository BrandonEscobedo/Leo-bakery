using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
    public partial class granel : Form
    {
        public granel()
        {
            InitializeComponent();
        }
       public double precio_u;
       public  String cantidad_menu;

        private void granel_Load(object sender, EventArgs e)
        {
            lbl_precio_unidad.Text = precio_u.ToString();
        }
        private void calcular_precio()
        {
            try
            {

            double total;
            double cantidad;
            cantidad =Convert.ToDouble( txt_cantidad.Text);
            total = precio_u * cantidad;
            
            txt_importe.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void lbl_precio_unidad_Click(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            calcular_precio();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            menu_principal.indicador_cantidad =Convert.ToDouble(txt_cantidad.Text);      
            Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void txt_importe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
