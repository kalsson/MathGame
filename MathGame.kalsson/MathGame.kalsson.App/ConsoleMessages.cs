namespace MathGame.kalsson.App;

public class ConsoleMessages
{
    /// <summary>
    /// TODO: Comment this method
    /// </summary>
    public static void ApplicationInfo()
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
}