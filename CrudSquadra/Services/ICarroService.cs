using CrudSquadra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.Services
{
    public interface ICarroService
    {
        bool AdicionarCarro(Carro carro);
        List<Carro> RetonarListaCarro();
        Carro RetornarCarroPorId(int id);
        bool AtualizarCarro(Carro novoCarro);
        bool DeletarCarro(int id);
    }
}
