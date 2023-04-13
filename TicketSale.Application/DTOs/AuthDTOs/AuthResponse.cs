using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.AuthDTOs
{
    public class AuthResponse
    {
        public string? AuthToken { get; set; }
        public int? ClientId { get; set; }
        public bool IsValid { get; set; }
    }
}
