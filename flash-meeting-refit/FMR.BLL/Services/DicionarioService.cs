using FMR.DL.Response.Client.DicionarioClient;
using FMR.DL.Service.BLL;
using Refit;
using System;
using System.Threading.Tasks;

namespace FMR.BLL.Services
{
    public class DicionarioService : IDicionarioService
    {

        private readonly IDicionarioClient _dicionarioClient;

        public DicionarioService(IDicionarioClient dicionarioClient)
        {
            _dicionarioClient = dicionarioClient;
        }

        public async Task<DicionarioClientResponse> BuscarDefinicao(string palavra)
        {
            ApiResponse<DicionarioClientResponse> definicao = await _dicionarioClient.BuscarDefinicao(palavra);

            if (!definicao.IsSuccessStatusCode)
            {
                throw new Exception(definicao.Error.Message);
            }

            return definicao.Content;
        }

        public async Task<DicionarioClientResponse> BuscarExemploFrase(string palavra)
        {
            ApiResponse<DicionarioClientResponse> exemploFrase = await _dicionarioClient.BuscarExemploFrase(palavra);

            if (!exemploFrase.IsSuccessStatusCode)
            {
                throw new Exception(exemploFrase.Error.Message);
            }

            return exemploFrase.Content;
        }

        public async Task<DicionarioClientResponse> BuscarPalavra(string palavra)
        {
            ApiResponse<DicionarioClientResponse> palavraRespose = await _dicionarioClient.BuscarPalavra(palavra);

            if (!palavraRespose.IsSuccessStatusCode)
            {
                throw new Exception(palavraRespose.Error.Message);
            }

            return palavraRespose.Content;
        }

        public async Task<DicionarioClientResponse> BuscarSinonimos(string palavra)
        {
            ApiResponse<DicionarioClientResponse> sinonimos = await _dicionarioClient.BuscarSinonimos(palavra);

            if (!sinonimos.IsSuccessStatusCode)
            {
                throw new Exception(sinonimos.Error.Message);
            }

            return sinonimos.Content;
        }
    }
}
