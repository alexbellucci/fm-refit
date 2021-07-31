using FMR.DL.Response.Client.DicionarioClient;
using FMR.DL.Service.BLL;
using Refit;
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

            return definicao.Content;
        }

        public async Task<DicionarioClientResponse> BuscarExemploFrase(string palavra)
        {
            ApiResponse<DicionarioClientResponse> exemploFrase = await _dicionarioClient.BuscarExemploFrase(palavra);

            return exemploFrase.Content;
        }

        public async Task<DicionarioClientResponse> BuscarPalavra(string palavra)
        {
            ApiResponse<DicionarioClientResponse> palavraRespose = await _dicionarioClient.BuscarPalavra(palavra);

            return palavraRespose.Content;
        }

        public async Task<DicionarioClientResponse> BuscarSinonimos(string palavra)
        {
            ApiResponse<DicionarioClientResponse> sinonimos = await _dicionarioClient.BuscarSinonimos(palavra);

            return sinonimos.Content;
        }
    }
}
