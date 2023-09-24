namespace EShop.API.Guard;

public static class MyGuard
{
    public static void ThrowIfNull<TException>(object value, string message) where TException : Exception
    {
        if (value != null)
        {
            return;
        }

        // Activator create a instance of TExceptions, return null if cannot create.
        // Then check instance is equal Exception.
        // If instance is not equal with Exception, throw ArgumentException.
        // Else throw TException.
        if (!(Activator.CreateInstance(typeof(TException), message) is Exception exceptionObj))
        {
            throw new ArgumentException(message);
        }

        throw exceptionObj;
    }
}