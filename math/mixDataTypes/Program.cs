string firstName = "Bob";
int soldWidgets = 7;
// compiler converts int into str to concatenate it with the str datatypes
Console.WriteLine(firstName + " sold " + soldWidgets + 7 + " widgets.");
// now it treats braced exp as int "order operations" like in math
Console.WriteLine(firstName + " sold " + (soldWidgets +7 )+ " widgets.");