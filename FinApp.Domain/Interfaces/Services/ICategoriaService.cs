using FinApp.Domain.Dtos.Requests;
using FinApp.Domain.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Interface específica para serviços de categoria
    /// </summary>
    public interface ICategoriaService :IBaseService<CategoriaRequest, CategoriaResponse, Guid>
    {

    }
}
