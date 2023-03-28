using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Application.DTOs.ArtistDTOs;
using TicketSale.Application.DTOs.ArtistHasEventDTOs.Response;
using TicketSale.Application.DTOs.ArtistHasGenreDTOs.Response;
using TicketSale.Application.DTOs.CityDTOs.Response;
using TicketSale.Application.DTOs.ClientDTOs.Response;
using TicketSale.Application.DTOs.EventDTOs.Response;
using TicketSale.Application.DTOs.GenreDTOs.Response;
using TicketSale.Application.DTOs.GenreHasEventDTOs.Response;
using TicketSale.Application.DTOs.PaymentStatusDTOs.Response;
using TicketSale.Application.DTOs.StateDTOs.Response;
using TicketSale.Application.DTOs.TicketDTOs.Response;
using TicketSale.Application.DTOs.TicketRegistrationDTOs.Response;
using TicketSale.Application.DTOs.UserDTOs.Response;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.ArtistHasEventEntity;
using TicketSale.Domain.Entities.ArtistHasGenreEntity;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.GenreEntity;
using TicketSale.Domain.Entities.GenreHasEventEntity;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Entities.StateEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Entities.UserEntity;

namespace TicketSale.Application.Mapper
{
    public class MapToDTO : Profile
    {
        public MapToDTO()
        {
            CreateMap<Artist, ArtistResponse>();

            CreateMap<City,CityResponseWithEntities>();
            CreateMap<City, CityResponseWithId>();



            CreateMap<Client, ClientResponseWithEntities>().ForMember(fln => fln.FullName, map => map.MapFrom(src => $"{src.PersonInfo.Name} {src.PersonInfo.Surname}"));

            CreateMap<Client, ClientResponseWithId>().ForMember(fln => fln.FullName, map => map.MapFrom(src => $"{src.PersonInfo.Name} {src.PersonInfo.Surname}"));

            CreateMap<Event, EventResponseWithEntities>();
            CreateMap<Event, EventResponseWithId>();

            CreateMap<Genre, GenreResponse>();

            CreateMap<PaymentStatus, PaymentStatusResponse>();

            CreateMap<State, StateResponse>();

            CreateMap<Ticket, TicketResponseWithEntities>();
            CreateMap<Ticket, TicketResponseWithId>();

            CreateMap<TicketRegistration, TicketRegistrationResponseWithEntities>();
            CreateMap<TicketRegistration, TicketRegistrationResponseWithId>();

            CreateMap<User, UserResponseWithEntities>();
            CreateMap<User, UserResponseWithId>();


            CreateMap<ArtistHasEvent, ArHasEvWithEntities>();
            CreateMap<ArtistHasEvent, ArHasEvWithId>();

            CreateMap<GenreHasEvent, GeHasEvWitEntities>();
            CreateMap<GenreHasEvent, GeHasEvWithId>();

            CreateMap<ArtistHasGenre, ArHasGeWithId>();
            CreateMap<ArtistHasGenre, ArHasGeWithEntities>();
        }
    }
}
