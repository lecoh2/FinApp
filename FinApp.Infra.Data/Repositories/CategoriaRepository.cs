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
    public class CategoriaRepository(DataContext dataContext)
        : BaseRepository<Categoria, Guid>(dataContext), ICategoriaRepository
        
    {
    }
}
