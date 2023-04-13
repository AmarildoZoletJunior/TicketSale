using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.GenreEntity;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class PaymentStatusRepository : BaseRepository<PaymentStatus>, IBaseRepository<PaymentStatus>, IPaymentStatus
    {
        public PaymentStatusRepository(TicketContext ticket) : base(ticket) { }


        public void Update(PaymentStatus paymentStatus)
        {
            _ticketContext.PaymentStatuses.Update(paymentStatus);
        }
    }
}
