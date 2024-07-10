using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.modulos.Menu_principal
{
    public partial class ventas_menu_principal : Form
    {
        public ventas_menu_principal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_turno_Click(object sender, EventArgs e)
        {
            caja.cierre_de_caja frm = new caja.cierre_de_caja();
            frm.ShowDialog();
        }
    }
}
