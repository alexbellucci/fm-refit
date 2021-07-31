using FMR.DL.Response.Client.AnimeClient;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMR.BLL.Services
{
    public interface IAnimeClient
    {

        [Get("/random")]
        Task<ApiResponse<AnimeClientResponse>> BuscarFalaAleatoria();

        [Get("/quotes")]
        Task<ApiResponse<IList<AnimeClientResponse>>> BuscarDezFalasAleatorias();

        [Get("/quotes/anime")]
        Task<ApiResponse<IList<AnimeClientResponse>>> BuscarFalasPorTituloAnime([AliasAs("title")] string tituloAnime);

        [Get("/quotes/character")]
        Task<ApiResponse<IList<AnimeClientResponse>>> BuscarFalasPorNomePersonagem([AliasAs("name")] string nomePersonagem);

        [Get("/available/anime")]
        Task<ApiResponse<IList<string>>> BuscarTodosAnimes();
    }
}
