int sum = 7 + 5;
int difference = 7 - 5;
int products =7 * 5 ;
int quotient = 7 / 5;
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine("sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Products: " + products );
//int doesn't support fractional digits
Console.WriteLine("Quotient: " + quotient);
//use decimal dt instead
Console.WriteLine($"Decimal Quotient: {decimalQuotient}");
//this wouldn't work
// int decimalQuotientA = 7 / 5.0m;
// int decimalQuotientB = 7.0m / 5;
// int decimalQuotientC = 7.0m / 5.0m;
// decimal decimalQuotientD = 7 / 5;