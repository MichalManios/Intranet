using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Models
{
    public class ZarzadzenieViewModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public string ContentOfDirective { get; set; }
        public bool Actual { get; set; }
        public bool HTML { get; set; }
    }
}
