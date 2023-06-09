﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.Paged;
using TicketSale.Data.Context;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Interfaces.Base;
using XAct;
using XAct.Domain.Repositories;

namespace TicketSale.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly TicketContext _ticketContext;
        public BaseRepository(TicketContext ticket) 
        {
            _ticketContext = ticket;
        }
        public Task<int> Create(T entity)
        {
            _ticketContext.Add(entity);
            var rows = _ticketContext.SaveChangesAsync();
            return rows;
        }

        public async Task<T> FindByIdAsync(int id)
        {
           return await _ticketContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<IEnumerable<T>> GetAllPaged(PagedParameters parameters)
        {
            return await _ticketContext.Set<T>().OrderBy(x => x.Id).Skip((parameters.NumberPage - 1) * parameters.PageSize).Take(parameters.PageSize).ToListAsync();
        }
    }
}
