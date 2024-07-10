using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace PUNTO_DE_VENTA.conexion
{
    class encriptar_en_texto
    {
        public static string Encriptar(string texto)
        {
            try
            {
                string key = "encriptacionddatostextozqf164tgñ";
                byte[] keyarray;
                byte[] arreglo_a_cifrar = UTF8Encoding.UTF8.GetBytes(texto);
                MD5CryptoServiceProvider hasmd5 = new MD5CryptoServiceProvider();
                keyarray = hasmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hasmd5.Clear();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyarray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform ctranform = tdes.CreateEncryptor();
                byte[] arrayresultado = ctranform.TransformFinalBlock(arreglo_a_cifrar, 0, arreglo_a_cifrar.Length);
                tdes.Clear();
                texto = Convert.ToBase64String(arrayresultado, 0, arrayresultado.Length);
            }
            catch (Exception ex)
            {

            }
            return texto;
        }
        public static string desencriptacion(string textoencriptado)
        {
            try
            {
                string key = "encriptacionddatostextozqf164tgñ";
                byte[] keyarray;
                byte[] array_a_decifrar = Convert.FromBase64String(textoencriptado);
                MD5CryptoServiceProvider hasmd5 = new MD5CryptoServiceProvider();
                keyarray = hasmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hasmd5.Clear();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyarray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cryptoTransform = tdes.CreateEncryptor();
                byte[] arrayresultado = cryptoTransform.TransformFinalBlock(array_a_decifrar, 0, array_a_decifrar.Length);
                tdes.Clear();
                textoencriptado = UTF8Encoding.UTF8.GetString(arrayresultado);
            }
            catch (Exception ex)
            {

            }
            return textoencriptado;
        }

    }
}
