using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borsa.Domain.Models
{
    public class Model
    {
        public string date { get; set; }
        public decimal open { get; set; }
        public decimal low { get; set; }
        public decimal high { get; set; }    
        public decimal close { get; set; }
        public float volume { get; set; }

    }
}
