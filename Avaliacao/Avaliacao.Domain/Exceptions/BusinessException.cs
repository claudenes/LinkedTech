namespace Avaliacao.Domain.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string msg) : base(msg) { }
    }
}
