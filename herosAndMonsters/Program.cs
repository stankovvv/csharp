int hero = 10;
int monster = 10;
//loop random num until one of the characters has 0 health
Random dice = new Random();
do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"The hero rolls a {roll}. The monster has {monster} health left.");

    if (monster <= 0) continue;
    
    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"The monster rolls a {roll}. The hero has {hero} health left.");
    
} while (hero > 0 && monster > 0);
Console.WriteLine(hero > 0 ? "The hero wins!" : "The monster wins!");