/* bool flag = true;

int value=0;
if (flag)

    
    Console.WriteLine($"Inside the block: {value}");

value = 10;
Console.WriteLine($"Outside the block: {value}"); */
//ACCESSING THE VARIABLE OUTSIDE THE BLOCK WILL CAUSE AN ERROR
//Console.WriteLine($"Outside the block: {value}"); 
//error too
/* int value = 20;
Console.WriteLine($"Outside the block: {value}"); */
string name = "Steve";

if (name == "Bob") 
    Console.WriteLine("Found Bob");
    
else if (name == "Steve")
     Console.WriteLine("Found Steve");

else 
    Console.WriteLine("Found Chuck");
