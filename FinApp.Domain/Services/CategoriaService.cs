using AutoMapper;
using FinApp.Domain.Dtos.Requests;
using FinApp.Domain.Dtos.Responses;
using FinApp.Domain.Entities;
using FinApp.Domain.Interfaces.Repositories;
using FinApp.Domain.Interfaces.Services;
using FinApp.Domain.Utils;
using FinApp.Domain.Validators;
using FluentValidation;
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
        public async Task<CategoriaResponse> AdicionarAsync(CategoriaRequest request)
        {
            var categoria = mapper.Map<Categoria>(request);
            var validator = new CategoriaValidator();
            var result = validator.Validate(categoria);
            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            var any = await unitOfWork.CategoriaRepository.AnyAsync(c => c.Nome.Equals(categoria.Nome));

            if (any)
                throw new InvalidOperationException("O nome da categoria já existe. tente outro");
            await unitOfWork.CategoriaRepository.AddAsync(categoria);
            return mapper.Map<CategoriaResponse>(categoria);
        }
        public async Task<CategoriaResponse> ModificarAsync(Guid id, CategoriaRequest request)
        {
            var categoria = await unitOfWork.CategoriaRepository.GetByIdAsync(id);
            if (categoria == null)
                throw new KeyNotFoundException("Categoria não encontrada");
            mapper.Map(request, categoria);

            var validator = new CategoriaValidator();
            var result = validator.Validate(categoria);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            var any = await unitOfWork.CategoriaRepository.AnyAsync
                (c => c.Nome.Equals(categoria.Nome) && c.Id != categoria.Id);
            if (any)
                throw new InvalidOperationException("Já existe outra  \r\ncategoria com este nome. Tente outro.");
            await unitOfWork.CategoriaRepository.UpdateAsync(categoria);
            return mapper.Map<CategoriaResponse>(categoria);
        }
        public async Task<CategoriaResponse> ExcluirAsync(Guid id)
        {
            var categoria = await unitOfWork.CategoriaRepository.GetByIdAsync(id);
            if (categoria == null)
                throw new KeyNotFoundException("Categoria não encontrada.");
            await unitOfWork.CategoriaRepository.DeleteAsync(categoria);

            return mapper.Map<CategoriaResponse>(categoria);
        }
        public async Task<PageResult<CategoriaResponse>> ConsultarAsync(int pageNumber, int pageSize)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0 || pageSize > 25) pageSize = 25;
            var pageResult = await unitOfWork.CategoriaRepository.GetAllAsync(pageNumber, pageSize);
            var response = new PageResult<CategoriaResponse>
            {
                Items = mapper.Map<List<CategoriaResponse>>(pageResult.Items),
                PageNumber = pageResult.PageNumber,
                PageSize = pageResult.PageSize,
                TotalCount = pageResult.TotalCount
            };
            return response;
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }

      

       
        public Task<CategoriaResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<CategoriaResponse> IBaseService<CategoriaRequest, CategoriaResponse, Guid>.AdicionarAsync(CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        Task<PageResult<CategoriaResponse>> IBaseService<CategoriaRequest, CategoriaResponse, Guid>.ConsultarAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        Task<CategoriaResponse> IBaseService<CategoriaRequest, CategoriaResponse, Guid>.ModificarAsync(Guid id, CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        Task<CategoriaResponse?> IBaseService<CategoriaRequest, CategoriaResponse, Guid>.ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
