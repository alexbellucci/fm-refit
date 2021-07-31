using FMR.DL.Response.Client.DicionarioClient;
using Refit;
using System.Threading.Tasks;

namespace FMR.BLL.Services
{
    public interface IDicionarioClient
    {

        [Get("/v2/entries/en-us/{palavra}")]
        Task<ApiResponse<DicionarioClientResponse>> BuscarPalavra(string palavra, [AliasAs("strictMatch")] string strictMatch = "false");

        [Get("/v2/entries/en-us/{palavra}")]
        Task<ApiResponse<DicionarioClientResponse>> BuscarDefinicao(string palavra,
                                                                     [AliasAs("fields")] string tituloAnime = "definitions",
                                                                     [AliasAs("strictMatch")] string strictMatch = "false"
                                                                    );

        [Get("/v2/entries/en-us/{palavra}")]
        Task<ApiResponse<DicionarioClientResponse>> BuscarExemploFrase(string palavra,
                                                                      [AliasAs("fields")] string tituloAnime = "examples",
                                                                      [AliasAs("strictMatch")] string strictMatch = "false"
                                                                     );

        [Get("/v2/entries/en-us/{palavra}")]
        Task<ApiResponse<DicionarioClientResponse>> BuscarSinonimos(string palavra,
                                                                      [AliasAs("fields")] string tituloAnime = "variantForms",
                                                                      [AliasAs("strictMatch")] string strictMatch = "false"
                                                                     );
    }
}
