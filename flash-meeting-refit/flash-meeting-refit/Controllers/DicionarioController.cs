using FMR.DL.Response.Client.DicionarioClient;
using FMR.DL.Service.BLL;
using Inscricao.DL.Response.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;
using System.Threading.Tasks;

namespace FMR.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DicionarioController : ControllerBase
    {
        private readonly IDicionarioService _dicionarioService;

        public DicionarioController(IDicionarioService dicionarioService)
        {
            _dicionarioService = dicionarioService;
        }

        [HttpGet("/dicionario/palavra")]
        [SwaggerOperation(OperationId = "BuscarPalavra",
                     Summary = "Buscar palavra")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DicionarioClientResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarPalavra(string palavra)
        {
            DicionarioClientResponse palavraResponse = await _dicionarioService.BuscarPalavra(palavra);
            return new OkObjectResult(palavraResponse);
        }

        [HttpGet("/dicionario/palavra/definicao")]
        [SwaggerOperation(OperationId = "BuscarDefinicao",
                             Summary = "Buscar definicao")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DicionarioClientResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarDefinicao(string palavra)
        {
            DicionarioClientResponse definicao = await _dicionarioService.BuscarDefinicao(palavra);
            return new OkObjectResult(definicao);
        }

        [HttpGet("/dicionario/palavra/exemplo-frase")]
        [SwaggerOperation(OperationId = "BuscarExemploFrase",
                             Summary = "Buscar exemplo frase")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DicionarioClientResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarExemploFrase(string palavra)
        {
            DicionarioClientResponse exemploFrase = await _dicionarioService.BuscarExemploFrase(palavra);
            return new OkObjectResult(exemploFrase);
        }

        [HttpGet("/dicionario/palavra/sinonimo")]
        [SwaggerOperation(OperationId = "BuscarSinonimos",
                             Summary = "Buscar sinonimos")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(DicionarioClientResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorViewModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarSinonimos(string palavra)
        {
            DicionarioClientResponse sinonimos = await _dicionarioService.BuscarSinonimos(palavra);
            return new OkObjectResult(sinonimos);
        }
    }
}
