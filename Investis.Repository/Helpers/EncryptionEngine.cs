using System;
using System.Security.Cryptography;
using System.Text;

namespace Investis.Helpers.EncryptionEngine
{
   
        public interface IEncryption
        {
            string EnCrypt(string String);
            string DeCrypt(string String);

        }



    public class Encryption : IEncryption
    {


        static readonly string SaltKey = "tehj-Jylkd-002Gkhjh";
        public string DeCrypt(string String)
        {
            var DecryptedString = "";

            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(String);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(SaltKey);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
           DecryptedString = Convert.ToBase64String(resultArray, 0, resultArray.Length);

            return DecryptedString;
        }

        public string EnCrypt(string String)
        {
            //var EncryptedString = "";
            //return EncryptedString;

            byte[] inputArray = Convert.FromBase64String(String);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(SaltKey);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}