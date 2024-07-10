using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Diagnostics;
namespace PUNTO_DE_VENTA.presentacion.asistente_de_instalacion_servidor
{
    public partial class instalacion_de_servidor_sql : Form
    {
     string nombre_equipo;
      
        private conexion.AES aes = new conexion.AES();
        string server = ".";
        public instalacion_de_servidor_sql()
        {
            InitializeComponent();
        }        
        private void instalacion_de_servidor_sql_Load(object sender, EventArgs e)
        {
            nombre_equipo = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            remplazar();
            Cursor = Cursors.WaitCursor;           
            comprobar_servidor_instalado();
       

        }
     private void remplazar()
        {
            txteliminarbase.Text = txteliminarbase.Text.Replace("daaa", txtnombre_base.Text);
            txtscript.Text = txtscript.Text.Replace("base_datos", txtnombre_base.Text);
            txt_usuario_crear.Text = txt_usuario_crear.Text.Replace("user_db", txt_usuario.Text);
            txt_usuario_crear.Text = txt_usuario_crear.Text.Replace("base_datos", txtnombre_base.Text);
            txt_usuario_crear.Text = txt_usuario_crear.Text.Replace("jb&db$Z10", txtcontraseña.Text);
            txtscript.Text = txtscript.Text + Environment.NewLine  + txt_usuario_crear.Text;
        } 
        private void comprobar_servidor_instalado_sql_express()
        {
            server = @".\" + txtnombre_sevidor.Text;
          
            ejecutar_script_eliminarbase_comprobacion();
           
            crear_base_datos_comprobacion();
        }
        private void comprobar_servidor_instalado()
        {
            server = ".";
           
            ejecutar_script_eliminarbase_comprobacion();
          
            crear_base_datos_comprobacion();
        }
        public void savetoXMl(Object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();

        }
        private void crear_base_datos_comprobacion()
        {
            var cnn = new SqlConnection("Server=" + server+ "; " + "database=master; integrated security=yes");
            string s = "CREATE DATABASE " + txtnombre_base.Text;
            var cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                savetoXMl(aes.Encrypt("Data Source=" + server+ ";Initial Catalog=" + txtnombre_base.Text + ";Integrated Security=True", conexion.desencriptacion.encriptt, int.Parse("256")));
                ejecutar_crear_procedimientos_tablas();
                panel_instalando.Visible = true;
               
                lbluscando.Text = @"Instancia Encontrada...
                No Cierre esta Ventana, se cerrara Automaticamente cuando este todo Listo";
                panel_btn_instalar.Visible = false;
                timer1.Start();
            }
            catch (Exception ex)
            {
             
            }


            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public void ejecutar_script_crearbase()
        {
          
            try
            {
                
             
                ejecutar_crear_procedimientos_tablas();
        
              
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
               
            }
        }
        string ruta;
        private void ejecutar_crear_procedimientos_tablas()
        {
            ruta = Path.Combine(Directory.GetCurrentDirectory(), script.Text + ".txt");
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;

            try
            {
                if (File.Exists(ruta) == false)
                {

                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtscript.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtscript.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);

            }

            try
            {
                Process Pross = new Process();

                Pross.StartInfo.FileName = "sqlcmd";
                Pross.StartInfo.Arguments = " -S " + server.ToString() + " -i " + script.Text + ".txt";
            
                Pross.Start();

 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void ejecutar_script_eliminarbase_comprobacion()
        {
            string str;
            SqlConnection mycon = new SqlConnection("Data Source=" + server + ";Initial Catalog=master;Integrated Security=True");
            str = txteliminarbase.Text;
            SqlCommand cmd = new SqlCommand(str, mycon);
            try
            {
                mycon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                if ((mycon.State == ConnectionState.Open))
                {
                    mycon.Close();
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnt_instalar_s_Click(object sender, EventArgs e)
        {
            try { 
            
       
          
          
            panel_instalando.Visible = true;
           
            }
            catch (Exception ex)
            {
               
            }
        }
        private void ejecutar()
        {
            Process pross = new Process();
            pross.StartInfo.FileName = "SQLEXPR_x64_ESN.exe";
            pross.StartInfo.Arguments = "/ConfigurationFile=ConfigurationFile.ini /ACTION=Install /IACCEPTSQLSERVERLICENSETERMS /SECURITYMODE=SQL /SAPWD="
                + txtcontraseña.Text + " /SQLSYSADMINACCOUNTS=" + nombre_equipo;
            pross.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            pross.Start();
            panel_instalando.Visible = true;
           
        }
       public static  int milisegundo;
        public static  int segundos;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            milisegundo += 1;
            mil.Text = Convert.ToString(milisegundo);

            if (milisegundo == 60)
            {
                segundos += 1;
                seg.Text = Convert.ToString(segundos);
                milisegundo = 0;
             
            }
            if (segundos == 15)
            {
                timer1.Stop();
                try
                {
                    File.Delete(ruta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Dispose();
                Application.Restart();

            }


        }

        private void timer_crear_ini_Tick(object sender, EventArgs e)
        {
            string rutaPREPARAR;
            StreamWriter sw;
            rutaPREPARAR = Path.Combine(Directory.GetCurrentDirectory(), "ConfigurationFile.ini");
            rutaPREPARAR = rutaPREPARAR.Replace("ConfigurationFile.ini", @"SQLEXPR_x64_ESN\ConfigurationFile.ini");
            if (File.Exists(rutaPREPARAR) == true)
            {
                timer_crear_ini.Stop();
            }

            try
            {
                sw = File.CreateText(rutaPREPARAR);
                sw.WriteLine(txtargumentos.Text);
                sw.Flush();
                sw.Close();
                timer_crear_ini.Stop();
            }
            catch (Exception ex)
            {
               
            }
        }
      public void ejecutar_script_eliminarbase()
        {
            string str;
            SqlConnection mycon = new SqlConnection("Data Source=" + server+ ";Initial Catalog=master;Integrated security=True");
            str = txteliminarbase.Text;
            SqlCommand cmd = new SqlCommand(str, mycon);
            try
            {
                mycon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            
            }
            finally
            {
                if ((mycon.State == ConnectionState.Open))
                {
                    mycon.Close();
                }
            }

        }
 
        public static int milisegundos;
        public static int segundos_2;
        public static int minutos;
        private void timer2_Tick(object sender, EventArgs e)
        {
            milisegundos += 1;
            lblmili.Text = Convert.ToString(milisegundos);
            if (milisegundos == 60)
            {
                segundos_2 += 1;
                lblsegundos.Text = Convert.ToString(segundos_2);
                milisegundos = 0;

            }
            if (segundos == 60)
            {
                minutos += 1;
                lblminutos.Text = Convert.ToString(minutos);

            }
            if (minutos == 6)
            {
                timer2.Enabled = false;
                ejecutar_script_eliminarbase();
                ejecutar_script_crearbase();
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            milisegundos += 1;
            lblmili.Text = Convert.ToString(milisegundos);
            if (milisegundos == 60)
            {
                segundos_2 += 1;
                lblsegundos.Text = Convert.ToString(segundos_2);
                milisegundos = 0;

            }
            if (segundos == 60)
            {
                minutos += 1;
                lblminutos.Text = Convert.ToString(minutos);

            }
            if (minutos == 1)
            {
                
                ejecutar_script_eliminarbase();
                ejecutar_script_crearbase();
               
            }
        }
    }
}
