using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.presentacion;
namespace PUNTO_DE_VENTA.presentacion.caja
{
    public partial class terminar_turno : Form
    {
        public terminar_turno()
        {
            InitializeComponent();
        }
        double restante_calcular;
        double resultado;
        int idusario;
        int idcaja;
        private void terminar_turno_Load(object sender, EventArgs e)
        {

            lbl_esperado.Text = Convert.ToString(cierre_de_caja.dinero_turno);
            restante_calcular = Convert.ToDouble(lbl_esperado.Text);
        }
        private void validar_resultado()
        {
            if(resultado == 0)
              {
                MessageBox.Show("Dinero total en caja correcto", "correcto", MessageBoxButtons.OK);
              }
            else if (resultado < restante_calcular & resultado!=0 )
            {
                MessageBox.Show("Falta dinero para cerrar caja y usted lo va a pagar", "efectivo", MessageBoxButtons.OK);
            }
            else if (resultado > restante_calcular)
            {
                MessageBox.Show("sobra dinero para cerrar caja y usted se lo va a quedar", "efectivo", MessageBoxButtons.OK);
            }
        }
        private void calcular_restante()
        {
            try
            {
            double hay_caja =Convert.ToDouble(  txt_efectivo.Text);
            resultado = hay_caja - restante_calcular;
            lbl_resultado.Text = resultado.ToString();
                validar_resultado();
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_efectivo_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void terminar_turno_caja()
        {
           
            datos.procedimientos_reutilizables.mostrar_inicio_sesion(ref idusario);
            datos.procedimientos_reutilizables.obtener_id_caja (ref idcaja);
            negocio.cerrar_turno prm = new negocio.cerrar_turno();
            datos.cerrar_abrir_caja fns = new datos.cerrar_abrir_caja();
            prm.fecha_fin = DateTime.Now;
            prm.fecha_cierre = DateTime.Now;
            prm.ingresos = cierre_de_caja.ingresos;
            prm.egresos = cierre_de_caja.egresos;
            prm.saldo_en_caja = 0;
            prm.id_usuario = idusario;
            prm.total_calculado = restante_calcular;
            prm.total_real = Convert.ToDouble(txt_efectivo.Text);
            prm.estado = "Caja cerrada";
            prm.diferencia = resultado;
            prm.idcaja = idcaja;
           if(  fns.cerrar_caja(prm)==true)
            {
                MessageBox.Show("caja cerrada correctamente");
            }
        }
        private void btn_cerrar_turno_Click(object sender, EventArgs e)
        {
            calcular_restante();
            terminar_turno_caja();
        }
    }
}
