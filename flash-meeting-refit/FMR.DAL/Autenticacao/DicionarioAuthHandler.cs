using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

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

                request.Headers.Add("app_id", "fa82b312");
                request.Headers.Add("app_key", "901dc38e4ccab520fd4168b7d5512fc5");

                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false); ;
            }
        }
    
}
