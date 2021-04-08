using CrudSquadra.Bordas.Adapter;
using CrudSquadra.DTO.Carro.AdicionarCarro;
using CrudSquadra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.Adapter
{
    public class AdicionarCarroAdapter : IAdicionarCarroAdapter
    {
        public Carro converterRequestParaCarro(AdicionarCarroRequest request)
        {
            var novoCarro = new Carro();
            novoCarro.marca = request.marca;
            novoCarro.modelo = request.modelo;
            return novoCarro;
        }
    }
}
