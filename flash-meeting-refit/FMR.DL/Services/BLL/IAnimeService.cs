using FMR.DL.Response.Client.AnimeClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMR.DL.Service.BLL
{
    public interface IAnimeService : IDependencyInjectionService
    {
        Task<AnimeClientResponse> BuscarFalaAleatoria();

        Task<IList<AnimeClientResponse>> BuscarDezFalasAleatorias();

        Task<IList<AnimeClientResponse>> BuscarFalasPorTituloAnime(string tituloAnime);

        Task<IList<AnimeClientResponse>> BuscarFalasPorNomePersonagem(string nomePersonagem);

        Task<IList<string>> BuscarTodosAnimes();
    }
}
