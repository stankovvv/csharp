// inst system random class
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
// take all rolls add calc them 
int total = roll1 + roll2 + roll3;
// visualize the calc
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//some logic
if (total > 10)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("It's Sorry you lose!");
}
// if two values are the same, extra points
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You got extra points!");
    total += 2;
}