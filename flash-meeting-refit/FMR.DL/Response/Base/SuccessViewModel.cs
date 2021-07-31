namespace Inscricao.DL.Response.Base
{
    public class SuccessViewModel<TEntity>

    {
        public SuccessViewModel(TEntity data)

        {
            Data = data;
        }

        public TEntity Data { get; }
    }
}