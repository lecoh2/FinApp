using AutoMapper;
using FinApp.Domain.Dtos.Requests;
using FinApp.Domain.Dtos.Response;
using FinApp.Domain.Entities;
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
            CreateMap<MovimentacaoRequest, Movimentacao>();
            CreateMap<Movimentacao, MovimentacaoResponse>();
            #endregion
        }
    }
}
