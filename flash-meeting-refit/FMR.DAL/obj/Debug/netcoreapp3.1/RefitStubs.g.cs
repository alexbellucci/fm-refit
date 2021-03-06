// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using FMR.DAL.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace FMR.DAL.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace FMR.BLL.Services
{
    using global::FMR.DL.Response.Client.AnimeClient;
    using global::Refit;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIAnimeClient : IAnimeClient
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIAnimeClient(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<ApiResponse<AnimeClientResponse>> IAnimeClient.BuscarFalaAleatoria()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarFalaAleatoria", new Type[] {  });
            return (Task<ApiResponse<AnimeClientResponse>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<IList<AnimeClientResponse>>> IAnimeClient.BuscarDezFalasAleatorias()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarDezFalasAleatorias", new Type[] {  });
            return (Task<ApiResponse<IList<AnimeClientResponse>>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<IList<AnimeClientResponse>>> IAnimeClient.BuscarFalasPorTituloAnime(string tituloAnime)
        {
            var arguments = new object[] { tituloAnime };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarFalasPorTituloAnime", new Type[] { typeof(string) });
            return (Task<ApiResponse<IList<AnimeClientResponse>>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<IList<AnimeClientResponse>>> IAnimeClient.BuscarFalasPorNomePersonagem(string nomePersonagem)
        {
            var arguments = new object[] { nomePersonagem };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarFalasPorNomePersonagem", new Type[] { typeof(string) });
            return (Task<ApiResponse<IList<AnimeClientResponse>>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<IList<string>>> IAnimeClient.BuscarTodosAnimes()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarTodosAnimes", new Type[] {  });
            return (Task<ApiResponse<IList<string>>>)func(Client, arguments);
        }
    }
}

namespace FMR.BLL.Services
{
    using global::FMR.DL.Response.Client.DicionarioClient;
    using global::Refit;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIDicionarioClient : IDicionarioClient
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIDicionarioClient(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<ApiResponse<DicionarioClientResponse>> IDicionarioClient.BuscarPalavra(string palavra, string strictMatch)
        {
            var arguments = new object[] { palavra, strictMatch };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarPalavra", new Type[] { typeof(string), typeof(string) });
            return (Task<ApiResponse<DicionarioClientResponse>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<DicionarioClientResponse>> IDicionarioClient.BuscarDefinicao(string palavra, string tituloAnime, string strictMatch)
        {
            var arguments = new object[] { palavra, tituloAnime, strictMatch };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarDefinicao", new Type[] { typeof(string), typeof(string), typeof(string) });
            return (Task<ApiResponse<DicionarioClientResponse>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<DicionarioClientResponse>> IDicionarioClient.BuscarExemploFrase(string palavra, string tituloAnime, string strictMatch)
        {
            var arguments = new object[] { palavra, tituloAnime, strictMatch };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarExemploFrase", new Type[] { typeof(string), typeof(string), typeof(string) });
            return (Task<ApiResponse<DicionarioClientResponse>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<ApiResponse<DicionarioClientResponse>> IDicionarioClient.BuscarSinonimos(string palavra, string tituloAnime, string strictMatch)
        {
            var arguments = new object[] { palavra, tituloAnime, strictMatch };
            var func = requestBuilder.BuildRestResultFuncForMethod("BuscarSinonimos", new Type[] { typeof(string), typeof(string), typeof(string) });
            return (Task<ApiResponse<DicionarioClientResponse>>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
