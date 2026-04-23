using RegistroComputadoras.ConfirmAdd;
using RegistroComputadoras.Form;
using RegistroComputadoras.Validations;
using RegistroComputadoras.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.UpdateComputer
{
    public class UpdateComputeR
    {
        public static async Task Updatecomputer()
        {
            await SeePcs.Seepcs();

            Console.WriteLine("Enter the id");
            bool num = int.TryParse(Console.ReadLine(), out int Id);

            var Findpc = await Services.ComputerService.GetByIdComputer(Id);

            if(Findpc is null)
            {
                Console.WriteLine("computer not foud");
                Console.WriteLine("would you like to add a computer");
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
                Console.WriteLine("Enter the new name");
                string Newname = Validation.ValidateString();
                Console.WriteLine("Enter the new brand");
                string Newbrand = ValidateBrand.Validatebrand();
                Console.WriteLine("Enter the new model");
                string NewModel = ValidationModel.Validationmodel();

                Findpc.Name = Newname;
                Findpc.Brand = Newbrand;
                Findpc.Model = NewModel;
                await Services.ComputerService.ModifyComputer(Findpc);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your computer has been updated successfully");
                Console.ResetColor();
                Console.ReadKey();
            }
            
        }
    }
}
