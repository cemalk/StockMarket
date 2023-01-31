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
    public class FillStockDto
    {
        private readonly StockDto _stockDto;

        public FillStockDto(StockDto stockDto)
        {
            _stockDto = stockDto;
        }

        public List<StockDto> FillTheDto(string stockName, List<Model> dtoList)
        {
            List<StockDto> list = new List<StockDto>();
            foreach (var item in dtoList)
            {
                _stockDto.StockName = stockName;
                _stockDto.date = item.date;
                _stockDto.open = item.open;
                _stockDto.low = item.low;
                _stockDto.high = item.high;
                _stockDto.close = item.close;
                _stockDto.volume = item.volume;
                list.Add(_stockDto);
            }
            return list;
        }
    }
}
