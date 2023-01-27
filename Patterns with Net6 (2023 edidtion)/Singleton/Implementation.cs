namespace Singleton;

///
/// The intent of the singleton is to ensure that a class only has
/// one instance, and to provide a global point of accsess to it
/// 

public class Logger {

    private static Logger? _instance;

    public static Logger Instance => _instance ?? (_instance = new Logger());

    protected Logger() { }

    public void Log(string message ) {
        Console.WriteLine($"Message: {message}");
    }
}


public class ThreadSafeLogger {

    // An instance would be constracted when we get this property first time 
    // in thread safe maner
    private static readonly Lazy<ThreadSafeLogger> _lazyLogger = 
        new Lazy<ThreadSafeLogger>(() => new ThreadSafeLogger());

    public static ThreadSafeLogger Instance => _lazyLogger.Value;

    protected ThreadSafeLogger() { }

    public void Log(string message ) {
        Console.Write($"Message: {message}");
    }
}

