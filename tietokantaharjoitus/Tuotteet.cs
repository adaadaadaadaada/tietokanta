using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tietokanta;



namespace Tuotteet
{
    public class Tuotteet
    {
        [Key]
        public string? Kirves { get; set; }
        public string? Abc { get; set; }
        public string? Def { get; set; }
        public string? Ghi { get; set; }
    }
}
