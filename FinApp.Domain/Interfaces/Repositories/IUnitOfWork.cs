using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        #region Operações de transação
        Task BeginTransaction();
        Task CommitAsync();
        Task RollbackAsync();
        #endregion
        #region Acesso aos repositórios 
        ICategoriaRepository CategoriaRepository { get; }
        IMovimentacaoRepository MovimentacaoRepository { get; }
        #endregion
    }
}
