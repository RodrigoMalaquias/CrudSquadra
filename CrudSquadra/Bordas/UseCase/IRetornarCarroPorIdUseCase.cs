using CrudSquadra.DTO.Carro.RetornarCarroPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.UseCase
{
    public interface IRetornarCarroPorIdUseCase
    {
        RetornarCarroPorIdResponse Executar(RetornarCarroPorIdRequest request);
    }
}
