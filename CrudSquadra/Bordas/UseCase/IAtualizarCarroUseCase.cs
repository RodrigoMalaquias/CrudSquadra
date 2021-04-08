using CrudSquadra.DTO.Carro.AtualizarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.UseCase
{
    public interface IAtualizarCarroUseCase
    {
        AtualizarCarroResponse Executar(AtualizarCarroRequest request);
    }
}
