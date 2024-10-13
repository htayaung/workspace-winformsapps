namespace System
{
    public class NoRecordFoundException : Exception
    {
        public NoRecordFoundException(string message = "No record found.") : base(message)
        {

        }
    }
}
