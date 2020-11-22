using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Models
{
    public class InstrukcjaViewModel
    {
        public int Id { get; set; }
        public string URLToFile { get; set; }
        public bool InstructionOrOther { get; set; }
        public string ContentOfInstruction { get; set; }
    }
}
