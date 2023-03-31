using System.Globalization;

namespace TicketSale.CrossCutting.Utils
{
    public static class ConvertToDecimal
    {
        public static decimal ConvertDecimal(string number)
        {
            var value = number.IndexOf(".", StringComparison.Ordinal);
            decimal finalValue = Convert.ToDecimal(number.Substring(0, value + 4), new CultureInfo("en-US"));
            return finalValue;
        }
    }
}
