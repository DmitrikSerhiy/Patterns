using Composite;

Console.Title = "Composite";


var root = new LDirectory("root");
var topLevelFile = new LFile("text.txt", 200);
var topLevelDirectory1 = new LDirectory("dir1");
var topLevelDirectory2 = new LDirectory("dir2");

root.Add(topLevelFile);
root.Add(topLevelDirectory1);
root.Add(topLevelDirectory2);

topLevelDirectory2.Add(new LFile("another.txt", 300));
topLevelDirectory2.Add(new LFile("hi there.txt", 200));


Console.WriteLine(root.GetSize()); // this is how composite work as a tree
Console.ReadLine();



