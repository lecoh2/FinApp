using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Domain.Dtos.Requests
{
    public record MovimentacaoRequest(
        string Nome, ///NOme da movimentação
        string Data, //data da movimentacao
        decimal Valor, //VAlor da movimentação
        Guid CategoriaId, // Id da categoria
        int Tipo  //Tipo (numerico)
                 );

}
