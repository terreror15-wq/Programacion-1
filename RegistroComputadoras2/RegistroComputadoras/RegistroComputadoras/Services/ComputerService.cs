using Microsoft.EntityFrameworkCore;
using RegistroComputadoras.Data;
using RegistroComputadoras.interfaces;
using RegistroComputadoras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Services
{
    public class ComputerService : IComputerService
    {
        private static DbContextPcRegistrer _app = new DbContextPcRegistrer();
        public ComputerService(DbContextPcRegistrer app)
        {
            _app = app;
        }
        public static async Task<IEnumerable<Computer>> GetComputers()
        {
            var computers = await _app.Computers.AsNoTracking().ToListAsync();
            return computers;

        }
        public static async Task Addcomputer(Computer pc)
        {
            await _app.Computers.AddAsync(pc);
            await _app.SaveChangesAsync();
        }
        public static async Task Deletecomputer(Computer pc)
        {
            _app.Computers.Remove(pc);
            await _app.SaveChangesAsync();
        }
        public static async Task<Computer> GetByIdComputer(int id)
        {
            var Computer = await _app.Computers.FindAsync(id);

            if (Computer is null)
            {
                Console.WriteLine("The computer has not been found");
                return null!;
            }
            return Computer;
        }
        public static async Task ModifyComputer(Computer Pc)
        {
            _app.Computers.Update(Pc);
            await _app.SaveChangesAsync();

        }
    }

}
