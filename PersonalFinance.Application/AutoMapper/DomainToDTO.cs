using AutoMapper;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Application.DTOs;

namespace PersonalFinance.Application.AutoMapper
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            CreateMap<BankAccount, BankAccountDTO>()
                .ForMember(d => d.Bank,
                           opt => opt.MapFrom(src => src.Bank))
                .ForMember(d => d.Type,
                           opt => opt.MapFrom(src => src.Type));
        }
    }
}