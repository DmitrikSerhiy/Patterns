namespace Flyweight;

// intent is to use sharing to support large number of fine-grained objects.
// it shares parts of the state between objects 
// it is not keep the state in the objects

/// <summary>
/// Flyweight
/// </summary>
public interface ICharacter {
    void Draw(string fontSize, string fontWeight);
}


public class CharacterA : ICharacter {
    private char symbol = 'a';
    public void Draw(string fontSize, string fontWeight) {
        Console.WriteLine($"Drawing a character '{symbol}' with font size {fontSize} and font weight of {fontWeight}");
    }
}

public class CharacterB : ICharacter {
    private char symbol = 'b';
    public void Draw(string fontSize, string fontWeight) {
        Console.WriteLine($"Drawing a character '{symbol}' with font size {fontSize} and font weight of {fontWeight}");
    }
}


public class CharacterFactory {
    private readonly Dictionary<char, ICharacter> _characters = new();

    public ICharacter? GetCharacter(char symbol) {
        if (_characters.ContainsKey(symbol)) {
            Console.WriteLine("Character reuse");
            return _characters[symbol];
        }

        if (symbol == 'a') {
            _characters.Add('a', new CharacterA());
            return _characters[symbol];
        }
        
        
        if (symbol == 'b') {
            _characters.Add('b', new CharacterB());
            return _characters[symbol];
        }

        return null;
    }
}