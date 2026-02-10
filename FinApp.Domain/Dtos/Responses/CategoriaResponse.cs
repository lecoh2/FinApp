using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Dtos.Responses
{/// <summary>
 /// Registro para saída de dados de categoria
 /// </summary
    public record CategoriaResponse(
        Guid Id, //Id da categoria
        string Nome // nome da categoria
            );

}
