using Singleton;

Console.Title = "Singleton";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance) {
    Console.WriteLine("same instances");
}

Logger.Instance.Log("hello world");


var instanceTS1 = ThreadSafeLogger.Instance;
var instanceTS2 = ThreadSafeLogger.Instance;

if (instanceTS1 == instanceTS2 && instanceTS2 == ThreadSafeLogger.Instance) {
    Console.WriteLine("same thread safe instances");
}

Logger.Instance.Log("thread safe hello world");

Console.ReadLine();