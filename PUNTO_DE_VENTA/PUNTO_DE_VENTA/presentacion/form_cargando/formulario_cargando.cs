using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.presentacion.form_cargando
{
    public partial class formulario_cargando : Form
    {
        public formulario_cargando()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cpb_cargando.Value += 1;
           
            cpb_cargando.Text = cpb_cargando.Value.ToString();
            if (cpb_cargando.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
                Dispose();
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 1)
            {
                
                timer2.Stop();
               
               
              
            }
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formulario_cargando_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblnombre_usuario.Text = presentacion.login.nombre_usuario;
            this.Opacity = 0.0;

            cpb_cargando.Value = 0;
            cpb_cargando.Minimum = 0;
            cpb_cargando.Maximum = 100;
            

        }
    }
}
