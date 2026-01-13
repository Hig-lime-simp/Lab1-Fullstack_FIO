// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Привет!");
// Console.WriteLine("Грошев Никита Андреевич");
// Console.WriteLine($"{DateTime.Now}");

string? name = Console.ReadLine();
Console.WriteLine($"Привет {name}!");
Console.WriteLine(DateTime.Now.DayOfWeek);

Console.WriteLine("Хотите продолжить? (y/n)");
string? ready = Console.ReadLine();
if (ready == "y")
{
    Console.WriteLine("You ready.");
}
else
{
    Console.WriteLine("Exit...");
}

