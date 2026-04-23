using RegistroComputadoras.ConfirmAdd;
using RegistroComputadoras.Form;
using RegistroComputadoras.Models;
using RegistroComputadoras.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Views
{
    public class SeePcs
    {
        public static async Task Seepcs()
        {
            var computers = await ComputerService.GetComputers();
           if(computers.Count() == 0)
            {
                Console.WriteLine("There are not computers registered yet.");
                Console.WriteLine("Would you like to add a computer?");
                string option = Console.ReadLine()!.ToLower().Trim();
                if(option == "yes")
                {
                    await AddPc.Addpc();
                }
                else if(option == "no")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("YOU CHOOSE NOT TO ADD A COMPUTER");
                    Console.WriteLine("--------------------------------");
                    Console.ReadKey();
                }
            }
            
            else
            {
                foreach(var pc in computers)
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("SHOWING ALL REGISTERED COMPUTERS");
                    Console.WriteLine("================================");
                    Console.WriteLine($"Id: {pc.Id}");
                    Console.WriteLine($"Name: {pc.Name}");
                    Console.WriteLine($"Brand: {pc.Brand}");
                    Console.WriteLine($"Model: {pc.Model}");
                    Console.WriteLine($"Status: {pc.Status}");
                    Console.ReadKey();
                }
            }
        }
    }
}
