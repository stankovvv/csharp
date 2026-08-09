/* //adds 3

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
} */

string[] names = {"Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    if (names[i] == "David")
    {
        names[i] = "Sunny";
    }
}
foreach (var name in names)
{
    Console.WriteLine(name);
}