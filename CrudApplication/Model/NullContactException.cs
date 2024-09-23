namespace CrudApplication.Model
{
    public class NullContactException : Exception
    {
        public NullContactException(string message) : base(message) 
        { 

        }
    }
}
