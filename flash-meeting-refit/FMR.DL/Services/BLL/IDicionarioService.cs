using FMR.DL.Response.Client.DicionarioClient;
using System.Threading.Tasks;

namespace FMR.DL.Service.BLL
{
    public interface IDicionarioService : IDependencyInjectionService
    {
        Task<DicionarioClientResponse> BuscarPalavra(string palavra);

        Task<DicionarioClientResponse> BuscarDefinicao(string palavra);

        Task<DicionarioClientResponse> BuscarExemploFrase(string palavra);

        Task<DicionarioClientResponse> BuscarSinonimos(string palavra);
    }
}
