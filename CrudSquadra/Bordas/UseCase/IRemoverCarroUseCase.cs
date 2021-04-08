using CrudSquadra.DTO.Carro.RemoverCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.UseCase
{
    public interface IRemoverCarroUseCase
    {
        RemoverCarroResponse Executar(RemoverCarroRequest request);
    }
}
