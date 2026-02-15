using FinApp.Domain.Entities;
using FinApp.Domain.Interfaces.Repositories;
using FinApp.Domain.Utils;
using FinApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infra.Data.Repositories
{
    public class MovimentacaoRepository(DataContext dataContext)
        : BaseRepository<Movimentacao, Guid>(dataContext), IMovimentacaoRepository

    {
        public override async Task<PageResult<Movimentacao>> GetAllAsync(int pageNumber, int pageSize)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;
            var query = dataContext.Set<Movimentacao>();

            var totalCount = await query.CountAsync();

            var items = await query
                      .Skip((pageNumber - 1) * pageSize)
                      .Take(pageSize)
                      .Include(m => m.Categoria) //JOIN 
                      .ToListAsync();
            return new PageResult<Movimentacao>
            {
                Items = items,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount
            };
        }
        public override async Task<Movimentacao?> GetByIdAsync(Guid id)
        {
            return await dataContext.Set<Movimentacao>()
                            .Include(m => m.Categoria) //JOIN 
                            .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
