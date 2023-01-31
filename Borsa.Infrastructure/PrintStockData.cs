using Borsa.Application.DTOs;
using Borsa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Borsa.Infrastructure
{
    public class PrintStockData
    {
        public void printStockData(string stockName, List<Model> theDataList)
        {
            foreach (var item in theDataList)
            {
                Console.WriteLine("Date: " + item.date +
                                  " Open: " + item.open +
                                  " Low: " + item.low +
                                  " High: " + item.high +
                                  " Close: " + item.close +
                                  " Volume: " + item.volume);
            }
            Console.ReadLine();
        }
    }
}
