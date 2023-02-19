using Proxy;

Console.Title = "Proxy";

// without proxy
IDoc doc = new PDocument("file.txt");  // long running (expensive) operation. It is used on init. But the object is not used yet.
doc.DisplayDoc(); // here is object is used


// with proxy
IDoc doc2 = new ProxyPDocument("file.txt"); 
doc2.DisplayDoc(); // now expensive operation is called when it's actually used. This is lazy initialization of PDocument 
// this is the same as Lazy<T> in .NET
