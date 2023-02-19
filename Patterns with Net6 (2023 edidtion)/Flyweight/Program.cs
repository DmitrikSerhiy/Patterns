using Flyweight;

Console.Title = "Flyweight";

var testString = "abba";

var factory = new CharacterFactory();

foreach (var symbol in testString) {
    var character = factory.GetCharacter(symbol);
    if (character is not null) {
        character.Draw("12", "600"); // it's something like a cache.
    }
}