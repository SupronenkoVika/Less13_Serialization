namespace Less13_Serialization
{
    public class InvalidFilePathException : Exception
    {
        public InvalidFilePathException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
