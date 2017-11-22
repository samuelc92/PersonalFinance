using AutoMapper;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Application.DTOs;
using PersonalFinance.Domain.Enuns;
using System;

namespace PersonalFinance.Application.AutoMapper
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            CreateMap<BankAccountDTO, BankAccount>()
                .ForMember(d => d.Bank,
                           opt => opt.MapFrom(src => src.Bank))
                .ForMember(d => d.Type,
                           opt => opt.MapFrom(src => src.Type));
        }
    }
}