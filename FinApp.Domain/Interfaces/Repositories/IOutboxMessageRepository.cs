using FinApp.Domain.Messages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Interfaces.Repositories
{
    public interface IOutboxMessageRepository : IBaseRepository<OutboxMessage, Guid>
    {
    }
}
