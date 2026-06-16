
// use dotnet new console -o to create new console app via terminal

//use system random method to create a dice logic
// create new dice object that is an instance of the random class that stores the random number generator
//always create new instance of random class when you want to generate random numbers, otherwise you might get the same number if you create multiple instances in a short time span because they are seeded with the current time
Random dice = new Random();
// next method hold some data from date and time and uses that to generate a random number
// so its stateful
// from 1 and do not reach the 7
int roll = dice.Next(1,7);
//then just output the result to the console


Console.WriteLine(roll);
// stateful means that your program can hold some data in memory 
