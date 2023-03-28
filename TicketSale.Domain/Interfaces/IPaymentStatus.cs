using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IPaymentStatus : IBaseRepository<PaymentStatus>
    {
        Task<PaymentStatus> Update(PaymentStatus paymentStatus);
    }
}
