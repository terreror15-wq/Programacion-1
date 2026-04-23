using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Infraestructure.SearchPc
{
    public class SearchPc
    {
        public static async Task  Searchcomputer()
        {
            Console.WriteLine("Enter the Id");
            bool num = int.TryParse(Console.ReadLine(), out int Id);

            var computer =  await Services.ComputerService.GetByIdComputer(Id);
            if(computer is not null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=======================");
                Console.WriteLine("Computer has been found");
                Console.WriteLine("=======================");
                Console.WriteLine($"Id: {computer.Id}");
                Console.WriteLine($"Name: {computer.Name}");
                Console.WriteLine($"Brand: {computer.Brand}");
                Console.WriteLine($"Model: {computer.Model}");
                Console.WriteLine($"Status: {computer.Status}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==================");
                Console.WriteLine("COMPUTER NOT FOUND");
                Console.WriteLine("==================");
                Console.ResetColor();
            }
        }
    }
}
