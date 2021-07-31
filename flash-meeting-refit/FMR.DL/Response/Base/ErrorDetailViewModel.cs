namespace Inscricao.DL.Response.Base
{
    public class ErrorDetailViewModel

    {
        public string? Code { get; set; }

        public string? Message { get; set; }

        public string? Target { get; set; }

        public ErrorDetailViewModel[]? Details { get; set; }
    }
}