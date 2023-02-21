namespace Iterator;

// intent to provide an access to the elements of aggregate object sequentially without exposing it's implementation


public class CollectionItem {
    public string Name { get; set; }
}


/// <summary>
/// iterator
/// </summary>
public interface ICustomIterator {
    CollectionItem First();
    CollectionItem Next();
    bool IsDone { get; }
    CollectionItem Current { get; }
}

/// <summary>
/// Aggregator
/// </summary>
public interface IItemCollection {
    ICustomIterator CreateIterator();
}

public class ItemIterator : ICustomIterator {
    private ItemCollection _itemCollection;
    private int _current = 0;

    public ItemIterator(ItemCollection collection) {
        _itemCollection = collection;
    }
    
    public CollectionItem First() {
        _current = 0;
        return _itemCollection.ToList()[_current];
    }

    public CollectionItem? Next() {
        _current++;
        if (!IsDone) {
            return _itemCollection.ToList()[_current];
        }
        else {
            return null;
        }
    }

    public bool IsDone => _current >= _itemCollection.Count;
    public CollectionItem Current => _itemCollection.ToList()[_current];
}

/// <summary>
/// concrete iterator
/// </summary>
public class ItemCollection: List<CollectionItem>, IItemCollection {
    
    public ICustomIterator CreateIterator() {
        return new ItemIterator(this);
    }
}