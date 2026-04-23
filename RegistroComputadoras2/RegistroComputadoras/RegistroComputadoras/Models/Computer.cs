using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand{ get; set; }
        public string? Model { get; set; }
        public string? Status { get; set; }
    }
}
