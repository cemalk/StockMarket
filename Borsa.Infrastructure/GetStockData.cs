using Borsa.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Diagnostics;
using Borsa.Domain.Models;

namespace Borsa.Infrastructure
{
    public class GetStockData
    {
        private StockDto _stockDto;

        public GetStockData(StockDto stockDto)
        {
            _stockDto = stockDto;
        }
        public async Task<List<Model>> RetrieveStockDataAsync(string stockName)
        {

            HttpClient httpClient = new HttpClient();
            var priceList = await httpClient.GetStringAsync($"https://financialmodelingprep.com/api/v3/historical-chart/4hour/{stockName}?apikey=f19edef5f2bc3d89a26cd901a7c45b8c");
            List<Model> priceListResult = JsonConvert.DeserializeObject<List<Model>>(priceList);
            return priceListResult;
        }
    }
}
