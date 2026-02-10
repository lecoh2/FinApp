using AutoMapper;
using FinApp.Domain.Dtos.Requests;
using FinApp.Domain.Dtos.Responses;
using FinApp.Domain.Interfaces.Repositories;
using FinApp.Domain.Interfaces.Services;
using FinApp.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Services
{
    /// <summary>
    /// Implementação dos serviços de domínio da entidade Movimentação
    /// </summary>
    public class MovimentacaoService(IUnitOfWork unitOfWork, IMapper mapper) : IMovimentacaoService
    {
        public Task<MovimentacaoResponse> AdicionarAsync(MovimentacaoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<MovimentacaoResponse>> ConsultarAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoRequest> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse> Modificar(Guid id, MovimentacaoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
