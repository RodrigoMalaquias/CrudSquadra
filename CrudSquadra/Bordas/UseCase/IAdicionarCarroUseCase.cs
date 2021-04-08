using CrudSquadra.DTO.Carro.AdicionarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.UseCase
{
    public interface IAdicionarCarroUseCase
    {
        AdicionarCarroResponse Executar(AdicionarCarroRequest request);
    }
}
