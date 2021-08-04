using FMR.DL.Response.Client.DicionarioClient;
using FMR.DL.Service.BLL;
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
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DicionarioClientResponse>> BuscarPalavra(string palavra)
        {
            DicionarioClientResponse palavraResponse = await _dicionarioService.BuscarPalavra(palavra);
            return new OkObjectResult(palavraResponse);
        }

        [HttpGet("/dicionario/palavra/definicao")]
        [SwaggerOperation(OperationId = "BuscarDefinicao",
                             Summary = "Buscar definicao")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DicionarioClientResponse>> BuscarDefinicao(string palavra)
        {
            DicionarioClientResponse definicao = await _dicionarioService.BuscarDefinicao(palavra);
            return new OkObjectResult(definicao);
        }

        [HttpGet("/dicionario/palavra/exemplo-frase")]
        [SwaggerOperation(OperationId = "BuscarExemploFrase",
                             Summary = "Buscar exemplo frase")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DicionarioClientResponse>> BuscarExemploFrase(string palavra)
        {
            DicionarioClientResponse exemploFrase = await _dicionarioService.BuscarExemploFrase(palavra);
            return new OkObjectResult(exemploFrase);
        }

        [HttpGet("/dicionario/palavra/sinonimo")]
        [SwaggerOperation(OperationId = "BuscarSinonimos",
                             Summary = "Buscar sinonimos")]
        [Produces(MediaTypeNames.Application.Json)]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DicionarioClientResponse>> BuscarSinonimos(string palavra)
        {
            DicionarioClientResponse sinonimos = await _dicionarioService.BuscarSinonimos(palavra);
            return new OkObjectResult(sinonimos);
        }
    }
}
