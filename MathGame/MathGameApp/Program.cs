// Display the application information
ConsoleMessages.ApplicationInfo();

// Display the menu to the user.
while (true)
{
    Console.WriteLine("Welcome to Math Game!");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Random Game");
    Console.WriteLine("6. Show Game History");
    Console.WriteLine("7. Exit");
    Console.WriteLine();
    
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    // Check the user's choice and perform corresponding action.
    switch (choice)
    {
        case "1":
            GameLogic.RunGame("addition");
            break;
        case "2":
            GameLogic.RunGame("subtraction");
            break;
        case "3":
            GameLogic.RunGame("multiplication");
            break;
        case "4":
            GameLogic.RunGame("division");
            break;
        case "5":
            GameLogic.RunGame("random");
            break;
        case "6":
            GameLogic.ShowHistory();
            break;
        case "7":
            return;
        default:
            Console.WriteLine("Invalid choice, please try again.");
            break;
    }
}