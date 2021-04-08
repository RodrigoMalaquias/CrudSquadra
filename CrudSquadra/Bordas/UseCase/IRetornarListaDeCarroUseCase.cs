using CrudSquadra.DTO.Carro.RetornarListaDeCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.UseCase
{
    public interface IRetornarListaDeCarroUseCase
    {
        RetornarListaDeCarroResponse Executar(RetornarListaDeCarroRequest request);
    }
}
