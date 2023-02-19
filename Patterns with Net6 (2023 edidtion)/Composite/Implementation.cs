namespace Composite;

// intent to compose objects into tree strucrute

/// <summary>
/// Component
/// </summary>
public abstract class LFileSystemItem {
    public string Name { get; }
    public LFileSystemItem(string name) {
        Name = name;
    }

    public abstract int GetSize();
}

/// <summary>
/// Leaf
/// </summary>
public class LFile : LFileSystemItem {
    private readonly int _size;

    public LFile(string name, int size) : base(name) {
        _size = size;
    }

    public override int GetSize() {
        return _size;
    }
}

public class LDirectory : LFileSystemItem {
    private List<LFileSystemItem> _fileSystemItems = new List<LFileSystemItem>();

    public LDirectory(string name) : base(name) { }

    public void Add(LFileSystemItem item) {
        _fileSystemItems.Add(item);
    }
    
    public override int GetSize() {
        return _fileSystemItems.Select(f => f.GetSize()).Sum();
    }
}
