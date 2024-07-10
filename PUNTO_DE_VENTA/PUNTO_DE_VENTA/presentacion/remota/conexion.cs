using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using PUNTO_DE_VENTA.conexion;
namespace PUNTO_DE_VENTA.presentacion.remota
{
    public partial class conexion : Form
    {
        public conexion()
        {
            InitializeComponent();
        }
        String stringConection;
        int id_c;
        String indicador_c;
        private AES aes = new AES();
        int idcaja=0;
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ip.Text))
            {
                conectar();
            }
            else
            {
                MessageBox.Show("Ingrese la IP antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void comprobar_conexion()
        {
            try
            {
                SqlConnection connection_m = new SqlConnection(stringConection);
                connection_m.Open();
                SqlCommand da = new SqlCommand("select IDusuarios from usuarios",connection_m);
                id_c = Convert.ToInt32(da.ExecuteScalar());
                indicador_c = "Conectado";

            }
            catch (Exception)
            {
                indicador_c = "Error";
              
            }
        }
        private void conectar()
        {
                string ip = txt_ip.Text;
                stringConection = "Data Source =" + ip + ";Initial Catalog=base_datos;Integrated Security=False;User Id=user_db;" +
               "Password=jb&db$Z10";
            MessageBox.Show(stringConection);
            comprobar_conexion();
            if (indicador_c == "Conectado")
            {
                MessageBox.Show(indicador_c);
                savetoXMl(aes.Encrypt(stringConection,desencriptacion.encriptt, int.Parse("256")));
                datos.procedimientos_reutilizables.obtener_id_caja(ref idcaja);
                if (idcaja > 0)
                {
                    MessageBox.Show("Conexion correcta, reinicie el sistema para ver reflejados los cambios", 
                        "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Dispose();
                }
                else
                {
                    remota.caja_remota.Conection = stringConection;
                    Dispose();
                    remota.caja_remota frm = new remota.caja_remota();
                    frm.ShowDialog();
                }
            }
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

        private void conexion_Load(object sender, EventArgs e)
        {

        }
    }
}
