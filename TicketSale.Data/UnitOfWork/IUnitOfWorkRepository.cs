using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Data.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        public Task Commit();
    }
}
