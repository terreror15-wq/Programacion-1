using RegistroComputadoras.ConfirmAdd;
using RegistroComputadoras.Form;
using RegistroComputadoras.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.DeleteComputer
{
    public class DeleteComputeR
    {
        public static async Task Deletecomputer()
        {
            Console.WriteLine("Enter the id's computer you want to delete");
            bool num = int.TryParse(Console.ReadLine(), out int Id);

            var Dpc = await ComputerService.GetByIdComputer(Id);
            if (Dpc is null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("computer not found \n try again: ");
                Console.ResetColor();
            }
            else
            {

                await Services.ComputerService.Deletecomputer(Dpc);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=============================");
                Console.WriteLine("COMPUTER DELETED SUCCESSFULLY");
                Console.WriteLine("=============================");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
