using AutoMapper;
using FinApp.Domain.Dtos.Requests;
using FinApp.Domain.Dtos.Responses;
using FinApp.Domain.Entities;
using FinApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Mappging
{
    /// <summary>
    /// Configuração dos mapeamentos do AutoMapper
    /// </summary>

    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            #region Categoria
            CreateMap<CategoriaRequest, Categoria>();
            CreateMap<Categoria, CategoriaResponse>();
            #endregion
            #region Movimentacao
            CreateMap<MovimentacaoRequest, Movimentacao>()
                .ForMember(dest => dest.Data,
                opt => opt.MapFrom(src => DateOnly.Parse(src.Data)))
                .ForMember(dest => dest.Tipo,
                opt => opt.MapFrom(src => (TipoMovimentacao)src.Tipo));


            CreateMap<Movimentacao, MovimentacaoResponse>()
                .ForMember(dest => dest.Data,
                opt => opt.MapFrom(src => src.Data.HasValue
                ? src.Data.Value.ToString("yyyy-MM-dd")
                : string.Empty))
                .ForMember(dest => dest.Tipo,
                opt => opt.MapFrom(src => src.Tipo.HasValue
                                   ? (int)src.Tipo.Value
                                   : 0));

            #endregion
        }
    }
}
