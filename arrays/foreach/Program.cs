// make instance str arrays of 3 elements
/*string[] fraudulentOrderIds = new string[3];

fraudulentOrderIds[0] = "A123";
fraudulentOrderIds[1] = "B456";
fraudulentOrderIds[2] = "C789";*/
// makes an err cause the instance is for 3 elements
//fraudulentOrderIds[3] = "D000"; 

string[] fraudulentOrderIds = ["A123", "B456", "C789"];

Console.WriteLine($"first {fraudulentOrderIds[0]}");
Console.WriteLine($"second {fraudulentOrderIds[1]}");
Console.WriteLine($"third {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "D000"; // reassign
Console.WriteLine($"reassigned first {fraudulentOrderIds[0]}");
//length  
Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");