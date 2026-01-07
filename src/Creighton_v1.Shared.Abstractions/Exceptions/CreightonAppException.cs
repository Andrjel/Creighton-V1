namespace Creighton_v1.Shared.Abstractions.Exceptions;

public abstract class CreightonAppException : Exception
{
    protected CreightonAppException() { }

    protected CreightonAppException(string message)
        : base(message) { }
}
