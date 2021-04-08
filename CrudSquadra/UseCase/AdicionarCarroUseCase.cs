using CrudSquadra.Bordas.Adapter;
using CrudSquadra.Bordas.Repositorios;
using CrudSquadra.DTO.Carro.AdicionarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSquadra.UseCase
{
    public class AdicionarCarroUseCase : IAdicionarCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioProdutos;
        private readonly IAdicionarCarroAdapter _adapter;

        public AdicionarCarroUseCase(IRepositorioCarros repositorioProdutos, IAdicionarCarroAdapter adapter)
        {
            _repositorioProdutos = repositorioProdutos;
            _adapter = adapter;
        }

        public AdicionarCarroResponse Executar(AdicionarCarroRequest request)
        {
            var response = new AdicionarCarroResponse();
            try
            {
                if(request.modelo.Length < 20) // Adicionando uma restricao ao tamanho do modelo
                {
                    response.msg = "Erro ao adicionar o carro";
                    return response;
                }
                var carroAdicionar = _adapter.converterRequestParaCarro(request);
                _repositorioProdutos.Add(carroAdicionar);
                response.msg = "Adicionando com sucesso";
                response.id = carroAdicionar.id;
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar o carro";
                return response;
            }
           
        }
    }
}
