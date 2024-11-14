
namespace CityRepoBL.Managers
{
    [Serializable]
    internal class CityException : Exception
    {
        public CityException()
        {
        }

        public CityException(string? message) : base(message)
        {
        }

        public CityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}