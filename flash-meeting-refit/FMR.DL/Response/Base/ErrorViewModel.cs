namespace Inscricao.DL.Response.Base
{
    public class ErrorViewModel

    {
        public ErrorViewModel(string code, string message)

        {
            Error = new ErrorDetailViewModel
            {
                Code = code,

                Message = message
            };
        }

        public ErrorViewModel(string code, string message, ErrorDetailViewModel[] details)

        {
            Error = new ErrorDetailViewModel
            {
                Code = code,

                Message = message,

                Details = details
            };
        }

        public ErrorViewModel(string code, string message, string target) : this(code, message)

        {
            Error.Target = target;
        }

        public ErrorDetailViewModel Error { get; set; }
    }
}