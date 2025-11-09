using System; // Εισάγει το βασικό namespace που περιέχει την κλάση Console και άλλες βασικές συναρτήσεις
using System.Diagnostics; // Εισάγει το namespace για διαχείριση διεργασιών (π.χ., Process.Start)
using System.Text; // Εισάγει το namespace για χειρισμό κειμένου (π.χ., StringBuilder)

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // Ορίζει την κωδικοποίηση εξόδου της κονσόλας σε UTF-8 για υποστήριξη ειδικών χαρακτήρων

        Console.Title = "User Registration Form"; // Ορίζει τον τίτλο του παραθύρου της κονσόλας

        Console.WriteLine("===== Eggrafi Xristi ====="); // Εμφανίζει έναν τίτλο στην κονσόλα
        Console.Write("Onoma: ");
        string name = Console.ReadLine();

        Console.Write("Epitheto: ");
        string surname = Console.ReadLine();

        Console.Write("Ilikia: ");
        string age = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Parakalw perimenete...");

        // Simulatsion loading...
        for (int i = 0; i < 3; i++) // Simulates a loading process
        {
            Thread.Sleep(600);
            Console.Write(".");
        }

        Console.WriteLine("\nTa dedomena egrafikan epitixws!");
        Console.WriteLine("Pata opoiodipote koumpi gia na sunexiseis...");
        Console.ReadKey();

        // Rickroll surprise!
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
            UseShellExecute = true
        }); // Opens the Rick Astley video in the default web browser



        Console.WriteLine(); // Κενή γραμμή για μορφοποίηση
        string art = @"
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿BRAVO⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⠟⣩⣴⣶⣦⣍⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⣿⣿⢏⣾⣿⣿⠿⣿⣿⣿⣌⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⠟⣩⣬⣭⠻⣿⣀⣿⣿⣿⢟⣤⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣷⣤⣒⠲⠶⢿⣘⣛⣻⠿⣿⣸⣿⣿⣷⣝⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⣿⣿⣿⠸⣿⣿⣿⣿⣿⣦⢹⣿⣿⣿⣿⣷⣌⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⡿⢉⣴⣶⣦⠙⣿⣿⣿⣿⡼⣿⣿⣿⣿⣿⢿⣷⡌⢿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⣷⡘⠿⠟⣛⡁⢻⣿⣿⣿⣿⣝⢿⣿⠻⣿⢮⣭⣥⣄⡹⣿⣿⣿⣿⣿⣿⣿ 
⣿⣿⡇⢿⣿⣿⣿⠘⣿⣿⣿⣿⣿⣷⣦⣟⡶⠶⢾⣭⣽⣗⡈⠻⣿⣿⣿⣿⣿ 
⣿⣿⣷⡈⣿⣿⣿⣧⣌⠛⠿⣿⣿⣿⣿⣿⣿⣷⣷⡲⣶⣶⣾⣷⣌⡛⢿⣿⣿ 
⣿⣿⣿⠗⡈⠻⣿⣿⡿⢛⣶⣤⣍⠻⣿⣿⣿⣿⣿⡿⠆⠻⠿⣿⣿⡿⠗⣢⣿ 
⣿⣿⡏⢼⣿⣷⣶⢋⣴⣿⣿⣿⣿⡇⢀⣠⠄⣠⣶⣶⣿⣿⣷⣶⣶⣶⣿⣿⣿ 
⣿⣿⣷⣌⠛⠛⠛⠈⠛⠛⠛⠛⢛⠁⢈⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⣿⣿⣿⣿⣿⣇⡈⢉⣩⡭⠽⢛⣒⣒⣒⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ 
⣿⣿⣿⣿⣿⣿⣿⣇⣉⣥⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿";  // ASCII art που απεικονίζει ένα μοτίβο
        Console.WriteLine(art); // Εκτυπώνει το ASCII art στην κονσόλα
    }
}
