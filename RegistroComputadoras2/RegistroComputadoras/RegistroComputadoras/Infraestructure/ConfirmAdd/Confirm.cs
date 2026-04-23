using Microsoft.EntityFrameworkCore;
using RegistroComputadoras.Data;
using RegistroComputadoras.Models;
using RegistroComputadoras.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.ConfirmAdd
{
    public class Confirm
    {

        public static List<Computer> computers = new List<Computer>();

        public static async Task Confirmadd(Computer pc)
        {
            while (true)
            {


                Console.WriteLine("Are you sure you wnat to add this Pc?");
                string option = Console.ReadLine()!.ToLower().Trim();

                if (option == "yes")
                {
                    await ComputerService.Addcomputer(pc);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Your computer has been added successfully");
                    Console.WriteLine("-----------------------------------------");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Computer not added");
                }

            }

        }
    }
}
