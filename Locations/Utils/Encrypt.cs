namespace Locations.Utils
{
    using System.Security.Cryptography;
    using System.Text;

    public class Encrypt
    {
        public static string EncryptMD5(string input)
        {
            MD5 md5Hash = MD5.Create();
            Byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
