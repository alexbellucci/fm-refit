using FMR.DL.Response.Client.AnimeClient;
using FMR.DL.Service.BLL;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMR.BLL.Services
{
    public class AnimeService : IAnimeService
    {

        private readonly IAnimeClient _animeClient;

        public AnimeService(IAnimeClient animeClient)
        {
            _animeClient = animeClient;
        }

        public async Task<AnimeClientResponse> BuscarFalaAleatoria()
        {
            ApiResponse<AnimeClientResponse> falaAleatoria = await _animeClient.BuscarFalaAleatoria();

            return falaAleatoria.Content;
        }

        public async Task<IList<AnimeClientResponse>> BuscarDezFalasAleatorias()
        {
            ApiResponse<IList<AnimeClientResponse>> falasAleatorias = await _animeClient.BuscarDezFalasAleatorias();

            return falasAleatorias.Content;
        }

        public async Task<IList<AnimeClientResponse>> BuscarFalasPorTituloAnime(string tituloAnime)
        {
            ApiResponse<IList<AnimeClientResponse>> falasAleatorias = await _animeClient.BuscarFalasPorTituloAnime(tituloAnime);

            return falasAleatorias.Content;
        }

        public async Task<IList<AnimeClientResponse>> BuscarFalasPorNomePersonagem(string nomePersonagem)
        {
            ApiResponse<IList<AnimeClientResponse>> falasAleatorias = await _animeClient.BuscarFalasPorNomePersonagem(nomePersonagem);

            return falasAleatorias.Content;
        }

        public async Task<IList<string>> BuscarTodosAnimes()
        {
            ApiResponse<IList<string>> animes = await _animeClient.BuscarTodosAnimes();

            return animes.Content;
        }
    }
}
