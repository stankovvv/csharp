//init the variables to push something into them
string? readResult;
string ValueEntered = "";
int numValue = 0;
bool validNumber = false;
//validate the num only between 5 - 10 
Console.WriteLine("Enter a number between 5 and 10:");
do
{
    //read the input from the user if not null then assign it to the ValueEntered variable and check if it is a valid number using TryParse method
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        ValueEntered = readResult;
        
    }
    validNumber = int.TryParse(ValueEntered, out numValue);
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        } 
        else
        {
            Console.WriteLine("Sorry, that is not a valid number. Please try again.");
        }
    }
    //loop until there is some valid number entered
} while (validNumber == false);
//display the valid number entered by the user
Console.WriteLine($"Your input value ({numValue}) has been accepted.");
//exit the program
readResult = Console.ReadLine();