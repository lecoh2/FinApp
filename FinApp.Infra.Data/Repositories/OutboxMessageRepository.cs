using FinApp.Domain.Interfaces.Repositories;
using FinApp.Domain.Messages.Models;
using FinApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infra.Data.Repositories
{
    public class OutboxMessageRepository (DataContext dataContext)
        :BaseRepository<OutboxMessage, Guid>(dataContext), IOutboxMessageRepository
    {

    }
}
