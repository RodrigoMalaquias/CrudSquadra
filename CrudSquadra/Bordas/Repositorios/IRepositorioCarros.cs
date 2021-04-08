using CrudSquadra.DTO.Carro.AdicionarCarro;
using CrudSquadra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.Bordas.Repositorios
{
    public interface IRepositorioCarros 
    {
        public void Add(Carro request);
    }
}
