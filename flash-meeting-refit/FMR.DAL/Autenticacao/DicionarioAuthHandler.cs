using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FMR.DAL.Autenticacao
{
    public class DicionarioAuthHandler : HttpClientHandler
    {
        public DicionarioAuthHandler()
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                                     CancellationToken cancellationToken)
        {
            //Insira suas credenciais aqui
            request.Headers.Add("app_id", "");
            request.Headers.Add("app_key", "");

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false); ;
        }
    }

}
