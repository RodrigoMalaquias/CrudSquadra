using CrudSquadra.Bordas.Repositorios;
using CrudSquadra.Context;
using CrudSquadra.DTO.Carro.AdicionarCarro;
using CrudSquadra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.Repositorios
{
    public class RepositorioCarros : IRepositorioCarros
    {
        private readonly LocalDbContext _local;

        public RepositorioCarros(LocalDbContext local)
        {
            _local = local;
        }

        public int Add(Carro request)
        {
            _local.carro.Add(request);
            _local.SaveChanges();
            return request.id;
        }
    }
}
