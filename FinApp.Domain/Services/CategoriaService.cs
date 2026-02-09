using AutoMapper;
using FinApp.Domain.Dtos.Requests;
using FinApp.Domain.Dtos.Response;
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
    // <summary>
    /// Implementação dos serviços de domínio da entidade Categoria
    /// </summary>

    public class CategoriaService (IUnitOfWork unitOfWork, IMapper mapper) : ICategoriaService
    {
        public Task<CategoriaResponse> AdicionarAsync(CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<CategoriaResponse>> ConsultarAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaRequest> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse> Modificar(Guid id, CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
