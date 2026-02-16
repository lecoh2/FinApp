using FinApp.Domain.Interfaces.Repositories;
using FinApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinApp.Infra.Data.Repositories
{
    /// <summary> 
    /// Unidade de trabalho para o EntityFramework 
    /// </summary>
    public class UnitOfWork : IUnitOfWork//(DataContext dataContext) : IUnitOfWork
    {
        //atributo para armazenar o contexto 
        private readonly DataContext _dataContext;

        //construtor para injeção de dependência 
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        #region Repositórios
        public ICategoriaRepository CategoriaRepository => 
            new CategoriaRepository(_dataContext);

        public IMovimentacaoRepository MovimentacaoRepository => 
            new MovimentacaoRepository(_dataContext);
        #endregion
        //construtor para injeção de dependência 
        private IDbContextTransaction? _transaction;
        #region Transações
        public async Task BeginTransaction()
        {
            ///implementarção
            if (_transaction == null)
                _transaction = await _dataContext.Database
                    .BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _dataContext.SaveChangesAsync();
                await _transaction.CommitAsync();
            }
            catch
            {
                await _transaction.RollbackAsync();
                throw;
            }
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
                await _transaction.RollbackAsync();
        }
        #endregion
        public void Dispose()

        {
            _dataContext.Dispose();
            if (_transaction != null)
                _transaction.Dispose();

        }
       
    }
}
