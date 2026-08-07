Random coin = new Random();
// use conditional instead of if statement
Console.WriteLine(coin.Next(0, 2) == 0 ? "Heads" : "Tails");