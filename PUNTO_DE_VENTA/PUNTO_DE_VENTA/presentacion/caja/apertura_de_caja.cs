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
    public partial class apertura_de_caja : Form
    {
        public apertura_de_caja()
        {
            InitializeComponent();
        }
        String serial_pc;
        int id_caja;
        bool estado;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void continuar()
        {
            Dispose();
            Menu_principal.menu_principal frm = new Menu_principal.menu_principal();
                    frm.ShowDialog();
         
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
        estado = datos.cerrar_abrir_caja.iniciar_caja(ref id_caja, Convert.ToDouble(txt_efectivo.Text));
        if (estado == true)
            {
                continuar();
            }
        }

        private void apertura_de_caja_Load(object sender, EventArgs e)
        {
              negocio.procedimientos_necesarios.cambiar_formato_puntos();
            datos.procedimientos_reutilizables.obtener_id_caja(ref id_caja);
            
        }     
        private void btn_omitir_Click(object sender, EventArgs e)
        {
            estado= datos.cerrar_abrir_caja.iniciar_caja(ref id_caja, 0.00);
            if (estado == true)
            {
                continuar();
            }  
        }

        private void txt_efectivo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            negocio.procedimientos_necesarios.evaluar_caracteres(txt_efectivo, e);
        }
    }
    }
