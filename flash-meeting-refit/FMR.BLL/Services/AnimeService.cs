using FMR.DL.Response.Client.AnimeClient;
using FMR.DL.Service.BLL;
using Refit;
using System;
using System.Collections.Generic;
using System.Net;
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

            if (!falaAleatoria.IsSuccessStatusCode)
            {
                throw new Exception("Nenhuma fala encontrada");
            }

            return falaAleatoria.Content;
        }

        public async Task<IList<AnimeClientResponse>> BuscarDezFalasAleatorias()
        {
            ApiResponse<IList<AnimeClientResponse>> falasAleatorias = await _animeClient.BuscarDezFalasAleatorias();

            if (falasAleatorias.StatusCode.Equals(HttpStatusCode.BadRequest))
            {
                throw new Exception("Algum parametro está errado!");
            }
            else if (falasAleatorias.StatusCode.Equals(HttpStatusCode.NotFound))
            {
                throw new KeyNotFoundException("Nenhuma fala encontrada");
            }


            return falasAleatorias.Content;
        }

        public async Task<IList<AnimeClientResponse>> BuscarFalasPorTituloAnime(string tituloAnime)
        {
            ApiResponse<IList<AnimeClientResponse>> falasPorTitulo = await _animeClient.BuscarFalasPorTituloAnime(tituloAnime);

            if (!falasPorTitulo.IsSuccessStatusCode)
            {
                throw new Exception(falasPorTitulo.Error.Message);
            }

            return falasPorTitulo.Content;
        }

        public async Task<IList<AnimeClientResponse>> BuscarFalasPorNomePersonagem(string nomePersonagem)
        {
            ApiResponse<IList<AnimeClientResponse>> falasPorNomePersonagem = await _animeClient.BuscarFalasPorNomePersonagem(nomePersonagem);

            if (!falasPorNomePersonagem.IsSuccessStatusCode)
            {
                throw new Exception(falasPorNomePersonagem.Error.Message);
            }

            return falasPorNomePersonagem.Content;
        }

        public async Task<IList<string>> BuscarTodosAnimes()
        {
            ApiResponse<IList<string>> animes = await _animeClient.BuscarTodosAnimes();

            if (!animes.IsSuccessStatusCode)
            {
                throw new Exception(animes.Error.Message);
            }

            return animes.Content;
        }
    }
}
