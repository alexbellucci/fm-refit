using FMR.DL.Response.Client.AnimeClient;
using FMR.DL.Response.Client.DicionarioClient;
using Inscricao.DL.Response.Base;
using System;
using System.Collections.Generic;
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
