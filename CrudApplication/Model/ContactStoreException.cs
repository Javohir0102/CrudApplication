namespace CrudApplication.Model
{
    public class ContactStoreException : Exception
    {
        public ContactStoreException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
