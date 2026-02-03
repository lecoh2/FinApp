using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        #region Operações de transação
        void BeginTransaction();
        void Commit();
        void Rollback();
        #endregion
        #region Acesso aos repositórios 
        public ICategoriaRepository CategoriaRepository { get; }
        public IMovimentacaoRepository MovimentacaoRepository { get; }
        #endregion
    }
}
