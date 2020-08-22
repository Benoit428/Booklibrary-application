using System;
using System.Runtime.Serialization;

namespace Bibliotheek_Console
{
    [Serializable]
    internal class Exceptions : Exception
    {
        public Exceptions()
        {
        }

        public Exceptions(string message) : base(message)
        {
        }

        public Exceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Exceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    public class DisplayBookException : Exception
    {
        public DisplayBookException()
            : base("Object is geen  boek")
        {
        }

        public DisplayBookException(string message)
            : base(message)
        {
        }

        public DisplayBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class UserException : Exception
    {
        public UserException()
            : base("Object is geen user")
        {
        }

        public UserException(string message)
            : base(message)
        {
        }

        public UserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
    public class DeleteUserException : Exception
    {
        public DeleteUserException()
            : base("Delete user: naam komt niet overeen met user")
        {
        }

        public DeleteUserException(string message)
            : base(message)
        {
        }

        public DeleteUserException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
    public class FileReaderException : Exception
    {
        public FileReaderException(string message) : base("File kan niet gevonden worden")
        {
        }

    }

}