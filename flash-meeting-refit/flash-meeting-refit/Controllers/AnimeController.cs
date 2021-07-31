using FMR.DL.Response.Client.AnimeClient;
using FMR.DL.Service.BLL;
using Inscricao.DL.Response.Base;
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
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AnimeClientResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarFalaAleatoria()
        {
            AnimeClientResponse falaAleatoria = await _animeService.BuscarFalaAleatoria();
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes/falas/aleatorio-dez")]
        [SwaggerOperation(OperationId = "BuscarDezFalasAleatorias",
                             Summary = "Buscar dez falas aleatorias")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IList<AnimeClientResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarDezFalasAleatorias()
        {
            IList<AnimeClientResponse> falaAleatoria = await _animeService.BuscarDezFalasAleatorias();
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes/falas/titulo")]
        [SwaggerOperation(OperationId = "BuscarFalaAleatoria",
                             Summary = "Buscar fala aleatoria")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IList<AnimeClientResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarFalasPorTituloAnime(string tituloAnime)
        {
            IList<AnimeClientResponse> falaAleatoria = await _animeService.BuscarFalasPorTituloAnime(tituloAnime);
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes/falas/personagem")]
        [SwaggerOperation(OperationId = "BuscarFalaAleatoria",
                             Summary = "Buscar fala aleatoria")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IList<AnimeClientResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarFalasPorNomePersonagem(string nomePersonagem)
        {
            IList<AnimeClientResponse> falaAleatoria = await _animeService.BuscarFalasPorNomePersonagem(nomePersonagem);
            return new OkObjectResult(falaAleatoria);
        }

        [HttpGet("/animes")]
        [SwaggerOperation(OperationId = "BuscarFalaAleatoria",
                             Summary = "Buscar fala aleatoria")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IList<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodosAnimes()
        {
            IList<string> falaAleatoria = await _animeService.BuscarTodosAnimes();
            return new OkObjectResult(falaAleatoria);
        }

    }
}
