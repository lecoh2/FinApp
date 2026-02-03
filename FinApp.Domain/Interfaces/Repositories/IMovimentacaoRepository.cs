using FinApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Interfaces.Repositories
{
    public interface IMovimentacaoRepository : IBaseRepository<Movimentacao, Guid>
    {
    }
}
