//In this example, the $ symbol allows you to reference the projectName 
//variable inside the braces,
// while the @ symbol allows you to use the unescaped \ character.
string projectName = "first project";
Console.WriteLine($@"c:\Output\{projectName}\Data");
