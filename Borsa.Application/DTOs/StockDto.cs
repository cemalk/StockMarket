using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Borsa.Domain.Models;

namespace Borsa.Application.DTOs
{
    public class StockDto : Model
    {
        public string StockName { get; set; }
    }
}
