using System.Text;
using XSystem.Security.Cryptography;

namespace TicketSale.CrossCutting.Helper
{
    public static class CryptoHelper
    {
        public static string EncryptPassword(string senha)
        {
            var data = Encoding.ASCII.GetBytes(senha);
            data = new SHA256Managed().ComputeHash(data);
            return Convert.ToBase64String(data);
        }
    }
}
