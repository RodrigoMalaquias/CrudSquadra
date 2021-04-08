using CrudSquadra.DTO.Carro.AdicionarCarro;
using CrudSquadra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.Bordas.Adapter
{
    public interface IAdicionarCarroAdapter
    {
        public Carro converterRequestParaCarro(AdicionarCarroRequest request);
    }
}
