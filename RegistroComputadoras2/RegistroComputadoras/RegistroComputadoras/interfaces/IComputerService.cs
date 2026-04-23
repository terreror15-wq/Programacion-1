using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroComputadoras.Models;

namespace RegistroComputadoras.interfaces
{
    public interface IComputerService
    {
        public static Task<IEnumerable<Computer>> GetComputers() => null!;
        public static Task Addcomputer(Computer pc) => null!;
        public static Task Deletecomputer(Computer pc) => null!;
        public static Task<Computer> GetByIdComputer(int id) => null!;
        public static Task ModifyComputer(Computer Pc) => null!;

    }
}