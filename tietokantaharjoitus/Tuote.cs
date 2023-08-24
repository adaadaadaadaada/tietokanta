using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tietokantaharjoitus
{

    internal class Tuote
    {
        [Key]
        public int? ID { get; set; }
        public string? Tuotenimi { get; set; }
        public int? Tuotenhinta { get; set; }
        public int? VarastoSaldo { get; set; }
    }
}
