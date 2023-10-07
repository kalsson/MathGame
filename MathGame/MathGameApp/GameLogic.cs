using System.Diagnostics;

namespace MathGameApp;

public class GameLogic
{
    static readonly List<string> GameHistory = new List<string>();
    
        /// <summary>
        /// Displays the game history.
        /// </summary>
        public static void ShowHistory()
        {
            if (GameHistory.Count == 0)
            {
                Console.WriteLine("No game history available.");
            }
            else
            {
                Console.WriteLine("Game History:");
                foreach (var game in GameHistory)
                {
                    Console.WriteLine(game);
                }
            }
        }

        /// <summary>
        /// Runs the math game based on the selected operation.
        /// </summary>
        /// <param name="operation">The math operation to be used.</param>
        public static void RunGame(string operation)
        {
            Console.WriteLine();
            Console.Write("Enter number of questions: ");
            int questionsCount = int.Parse(Console.ReadLine() ?? string.Empty);
            
            // Timer to keep track of time taken to complete the game.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            int correctAnswers = 0;
            Random rand = new Random();

            for (int i = 0; i < questionsCount; i++)
            {
                int num1 = rand.Next(0, 101);
                int num2 = rand.Next(0, 101);

                // For division, we make sure that the numbers are divisible.
                if (operation == "division")
                {
                    num2 = rand.Next(1, num1 + 1);
                    while (num1 % num2 != 0)
                    {
                        num2 = rand.Next(1, num1 + 1);
                    }
                }

                int answer = 0;
                switch (operation)
                {
                    case "addition":
                        answer = num1 + num2;
                        break;
                    case "subtraction":
                        answer = num1 - num2;
                        break;
                    case "multiplication":
                        answer = num1 * num2;
                        break;
                    case "division":
                        answer = num1 / num2;
                        break;
                    case "random":
                        // Pick a random operation for each question
                        string[] ops = { "addition", "subtraction", "multiplication", "division" };
                        operation = ops[rand.Next(0, ops.Length)];
                        i--; // Decrement i to repeat the loop iteration with the new operation.
                        continue;
                }
                
                Console.WriteLine();
                Console.Write($"What is {num1} {GetOperatorSymbol(operation)} {num2}?: ");
                int userAnswer = int.Parse(Console.ReadLine() ?? string.Empty);

                if (userAnswer == answer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ResetColor();
                    correctAnswers++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect!");
                    Console.ResetColor();
                }
            }

            // Stop timer
            stopwatch.Stop();

            string gameResult = $"{operation.ToUpper()} - Questions: {questionsCount}, Correct Answers: {correctAnswers}, Time: {stopwatch.Elapsed.TotalSeconds}s";
            GameHistory.Add(gameResult);

            Console.WriteLine();
            Console.WriteLine("Game Over!");
            Console.WriteLine();
            Console.WriteLine(gameResult);
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.Clear();
        }

        /// <summary>
        /// Returns the operator symbol for a given operation string.
        /// </summary>
        /// <param name="operation">The string representation of the operation.</param>
        /// <returns>The symbol representing the operation.</returns>
        private static string GetOperatorSymbol(string operation)
        {
            switch (operation)
            {
                case "addition":
                    return "+";
                case "subtraction":
                    return "-";
                case "multiplication":
                    return "*";
                case "division":
                    return "/";
                default:
                    return "";
            }
        }
}