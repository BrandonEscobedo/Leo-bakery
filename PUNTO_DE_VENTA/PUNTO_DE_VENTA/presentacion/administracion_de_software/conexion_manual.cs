using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
namespace PUNTO_DE_VENTA.presentacion.administracion_de_software
{
    public partial class conexion_manual : Form
    {
        private conexion.AES aes = new conexion.AES();

        public conexion_manual()
        {
            InitializeComponent();
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
        String dbcnString;
        public void ReadFromXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtcnstring.Text = (aes.Decrypt(dbcnString, conexion.desencriptacion.encriptt, int.Parse("256")));

            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savetoXMl(aes.Encrypt(txtcnstring.Text, conexion.desencriptacion.encriptt, int.Parse("256")));
            mostrar();
        }
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                MessageBox.Show("conexion realizada conrectamente", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("sin conexion a la base de datos", "conexion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void conexion_manual_Load(object sender, EventArgs e)
        {
            ReadFromXML();
        }

        private void txtcnstring_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
