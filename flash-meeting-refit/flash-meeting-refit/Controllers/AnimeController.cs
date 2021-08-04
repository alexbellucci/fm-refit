using FMR.DL.Response.Client.AnimeClient;
using FMR.DL.Service.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace FMR.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController
    {
        private readonly IAnimeService _animeService;

        public AnimeController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet("/animes/falas/aleatorio")]
        [SwaggerOperation(OperationId = "BuscarFalaAleatoria",
                             Summary = "Buscar fala aleatoria")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AnimeClientResponse>> BuscarFalaAleatoria()
        {
            AnimeClientResponse falaAleatoria = await _animeService.BuscarFalaAleatoria();
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes/falas/aleatorio-dez")]
        [SwaggerOperation(OperationId = "BuscarDezFalasAleatorias",
                             Summary = "Buscar dez falas aleatorias")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<AnimeClientResponse>>> BuscarDezFalasAleatorias()
        {
            IList<AnimeClientResponse> falaAleatoria = await _animeService.BuscarDezFalasAleatorias();
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes/falas/titulo")]
        [SwaggerOperation(OperationId = "BuscarFalasPorTituloAnime",
                             Summary = "Buscar falas por titulo do anime")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<AnimeClientResponse>>> BuscarFalasPorTituloAnime(string tituloAnime)
        {
            IList<AnimeClientResponse> falaAleatoria = await _animeService.BuscarFalasPorTituloAnime(tituloAnime);
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes/falas/personagem")]
        [SwaggerOperation(OperationId = "BuscarFalasPorNomePersonagem",
                             Summary = "Buscar falas por nome do personagem")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<AnimeClientResponse>>> BuscarFalasPorNomePersonagem(string nomePersonagem)
        {
            IList<AnimeClientResponse> falaAleatoria = await _animeService.BuscarFalasPorNomePersonagem(nomePersonagem);
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes")]
        [SwaggerOperation(OperationId = "BuscarTodosAnimes",
                             Summary = "Buscar todos animes")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<string>>> BuscarTodosAnimes()
        {
            IList<string> falaAleatoria = await _animeService.BuscarTodosAnimes();
            return new OkObjectResult(falaAleatoria);
        }

    }
}
