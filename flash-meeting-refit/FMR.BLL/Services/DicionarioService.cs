using FMR.DAL;
using FMR.DL.Response.Client.AnimeClient;
using FMR.DL.Response.Client.DicionarioClient;
using FMR.DL.Service.BLL;
using Inscricao.DL.Response.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMR.BLL.Services
{
    public class DicionarioService : IDicionarioService
    {

        private readonly IDicionarioClient _dicionarioClient;

        public DicionarioService(IDicionarioClient dicionarioClient)
        {
            _dicionarioClient = dicionarioClient;
        }

        public async Task<DicionarioClientResponse> BuscarDefinicao(string palavra)
        {
            ApiResponse<DicionarioClientResponse> definicao = await _dicionarioClient.BuscarDefinicao(palavra);

            return definicao.Content;
        }

        public async Task<DicionarioClientResponse> BuscarExemploFrase(string palavra)
        {
            ApiResponse<DicionarioClientResponse> exemploFrase = await _dicionarioClient.BuscarExemploFrase(palavra);

            return exemploFrase.Content;
        }

        public async Task<DicionarioClientResponse> BuscarPalavra(string palavra)
        {
            ApiResponse<DicionarioClientResponse> palavraRespose = await _dicionarioClient.BuscarPalavra(palavra);

            return palavraRespose.Content;
        }

        public async Task<DicionarioClientResponse> BuscarSinonimos(string palavra)
        {
            ApiResponse<DicionarioClientResponse> sinonimos = await _dicionarioClient.BuscarSinonimos(palavra);

            return sinonimos.Content;
        }
    }
}
