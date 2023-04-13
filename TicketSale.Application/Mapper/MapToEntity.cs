using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Application.DTOs.AuthDTOs;
using TicketSale.Application.DTOs.ClientDTOs.Request;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.VO;

namespace TicketSale.Application.Mapper
{
    public class MapToEntity : Profile
    {
        public MapToEntity()
        {
            CreateMap<AuthRequest, Client>();

            CreateMap<ClientRequest, Client>()
                .ForMember(x => x.PersonInfo, map => map.MapFrom(x => new PersonInfo { Birthday = x.Birthday, CPF = x.CPF, Name = x.Name, Surname = x.Surname }));

        }
    }
}
