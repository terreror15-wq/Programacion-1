
using RegistroComputadoras.ConfirmAdd;
using RegistroComputadoras.Models;
using RegistroComputadoras.StatusMenu;
using RegistroComputadoras.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Form
{
    public class AddPc
    {
        public static async Task Addpc()
        {
            Console.WriteLine("Enter the Pc's name ");
            string Name = Validation.ValidateString();
            Console.WriteLine("Enter the brand");
            string Brand = ValidateBrand.Validatebrand();
            Console.WriteLine("Enter the model");
            string Model = ValidationModel.Validationmodel();
            string Status = statusMenu.Statusmenu();

            Computer Pc = new Computer();

            Pc.Name = Name;
            Pc.Brand = Brand;
            Pc.Model = Model;
            Pc.Status = Status;
            await Confirm.Confirmadd(Pc);
        }
    }
}
