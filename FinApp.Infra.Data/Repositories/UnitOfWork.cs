using FinApp.Domain.Interfaces.Repositories;
using FinApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infra.Data.Repositories
{
    public class UnitOfWork(DataContext dataContext) : IUnitOfWork
    {
        public ICategoriaRepository CategoriaRepository => throw new NotImplementedException();

        public IMovimentacaoRepository MovimentacaoRepository => throw new NotImplementedException();

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
