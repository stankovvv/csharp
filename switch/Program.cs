// when you change the value of employeeLevel to 201, it will go to default case and print Associate as title.
int employeeLevel = 201;


string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;

    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
Console.WriteLine($"Employee: {employeeName}, Title: {title}");