// Display the application information
ApplicationInfo();

// Display the main menu
MainMenu();

// Get the user's choice and store it in a variable called userChoice
int userChoice = GetUserChoice();

void ApplicationInfo()
{
    string appName = "MathGameApp";
    string appVersion = "1.0.0";
    string appAuthor = "Jonas Karlsson";

    Console.WriteLine($"{appName}");
    Console.WriteLine($"{appVersion}");
    Console.WriteLine($"{appAuthor}");

    for (int i = 0; i < appAuthor.Length; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
    Console.WriteLine();
}

void MainMenu()
{
    // TODO: Build the menu
    
    Console.WriteLine("Please choose a menu option:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
}

int GetUserChoice()
{
    bool continueLoop;
    int number;

    do
    {
        Console.Write("Please enter your choice: ");
        string? choice = Console.ReadLine();
        int.TryParse(choice, out number);

        if (string.IsNullOrWhiteSpace(choice))
        {
            Console.WriteLine("You tried to enter text or an empty value, please try again!");
            continueLoop = true;
        }
        else if (number is < 1 or > 5)
        {
            Console.WriteLine("You tried to enter a number that is not between 1 and 5, please try again!");
            continueLoop = true;
        }
        else
        {
            continueLoop = false;
        }
    } while (continueLoop);
    
    return number;
}

void Addition()
{
    // TODO: Build the addition game
}

void Subtraction()
{
    // TODO: Build the subtraction game
}

void Multiplication()
{
    // TODO: Build the multiplication game
}

void Division()
{
    // TODO: Build the division game
}

