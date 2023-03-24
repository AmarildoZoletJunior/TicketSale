using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.Base;

namespace TicketSale.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T FindById(int id);
        List<T> GetAll();
        void Delete(int id);
        int Create(T t);
        T Update(T t);
    }
}
