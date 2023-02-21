using Iterator;

Console.Title = "Iterator";

var collection = new ItemCollection();

collection.Add(new CollectionItem { Name = "123"});
collection.Add(new CollectionItem { Name = "456"});
collection.Add(new CollectionItem { Name = "789"});
collection.Add(new CollectionItem { Name = "000"});

var iterator = collection.CreateIterator();

for (var item = collection.First(); !iterator.IsDone; item = iterator.Next()) {
    Console.WriteLine(item.Name);
}

Console.ReadKey();