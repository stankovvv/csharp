string? readRes;
string roleName= "";

bool validRole = false; 
do
{
    Console.WriteLine("Enter your role (Admin, manager, user):");
    readRes = Console.ReadLine();
    if (readRes != null)
    {
        roleName = readRes.Trim();
    }
    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validRole = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }
} while (validRole == false);

Console.WriteLine($"Your role name ({roleName}) has been accepted.");
readRes = Console.ReadLine();