using FinApp.Domain.Entities;
using FinApp.Domain.Interfaces.Repositories;
using FinApp.Infra.Data.Contexts;
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
    }
}