using ConcatetionLogicLibrary;

bool inputValidated = false;
ConcatetionLogic library = new();
while (!inputValidated)
{
    Console.Write("Enter username: ");
    var username = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(username))
    {
        inputValidated = true;
        Console.WriteLine(library.Output(username));
    }
    else
    {
        Console.WriteLine("Invalid username.\n");
    }
}