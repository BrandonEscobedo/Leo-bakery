
using System.Xml;
namespace PUNTO_DE_VENTA.conexion
{
     class desencriptacion
    {
        static private AES aes = new AES();
        static public string CnString;
        static string DBcnString;
        static public string encriptt = "ada3dendadd.encrica04knad=1-1=.adasdadsñ22/22";
        public static object checkserver()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            DBcnString = root.Attributes[0].Value;
            CnString =  (aes.Decrypt(DBcnString, encriptt, int.Parse("256")));
            return CnString;

        }
        internal class label
        {

        }
        public static object UsuariosEncryp()
        {
            XmlDocument doc = new XmlDocument();
            label root = new label();

            DBcnString = root.ToString();
            CnString = (aes.Decrypt(DBcnString, encriptt, int.Parse("256")));
            return CnString;

        }
    }
   
}
