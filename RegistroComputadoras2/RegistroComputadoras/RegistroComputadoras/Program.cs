using RegistroComputadoras.DeleteComputer;
using RegistroComputadoras.Form;
using RegistroComputadoras.Infraestructure.SearchPc;

using RegistroComputadoras.UpdateComputer;
using RegistroComputadoras.Views;

string menu = @"
╔══════════════════════════════════════════════╗
║        COMPUTER MANAGEMENT SYSTEM           ║
╠══════════════════════════════════════════════╣
║  1 ➜ Add PC                                 ║
║  2 ➜ View PCs                               ║
║  3 ➜ Update PC                              ║
║  4 ➜ Delete PC                              ║
║  5 ➜ Search pc  
║  6 ➜ Exit  
║  
╚══════════════════════════════════════════════╝
";

while (true)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔══════════════════════════════════════════════╗");
    Console.WriteLine("║        WELCOME TO THE SYSTEM 💻            ║");
    Console.WriteLine("╚══════════════════════════════════════════════╝");
    Console.ResetColor();

    Console.WriteLine(menu);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Select an option ➜ ");
    Console.ResetColor();

    bool num = int.TryParse(Console.ReadLine(), out int option);

    if (!num)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n❌ Invalid option. Please enter a number.");
        Console.ResetColor();
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        continue;
    }

    switch (option)
    {
        case 1:
            await AddPc.Addpc();
            break;

        case 2:
            await SeePcs.Seepcs();
            break;

        case 3:
            await UpdateComputeR.Updatecomputer();
            break;

        case 4:
            await DeleteComputeR.Deletecomputer();
            break;

        case 5:
            await SearchPc.Searchcomputer();
            break;
        case 6:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✔ Exiting the system...");
            Console.ResetColor();
            return;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Option not available.");
            Console.ResetColor();
            break;
    }

    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
}