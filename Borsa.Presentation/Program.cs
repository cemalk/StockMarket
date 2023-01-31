using Borsa.Application.DTOs;
using Borsa.Domain.Models;
using Borsa.Infrastructure;
namespace Borsa.Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stockDto = new StockDto();
            var getStockData = new GetStockData(stockDto);
            var retrieveDataFromApi = new RetrieveDataFromApi(getStockData, stockDto);
            var printStockData = new PrintStockData();
            var fillStockDto = new FillStockDto(stockDto);
            var PrintStockDatas = new PrintStockDatas(printStockData);
            var fillTheDto = new FillTheDto(fillStockDto);


            Console.WriteLine("Enter the stock you want to display its price");
            string stockName = Console.ReadLine();
            if (stockName != null)
            {
                var data = retrieveDataFromApi.getData(stockDto, stockName);
                PrintStockDatas.print(stockName, data);
                fillStockDto.FillTheDto(stockName, data);

            }
            else
            {
                Console.WriteLine("Enter valid value");
            }
        }
    }

    public class RetrieveDataFromApi
    {
        private readonly GetStockData _getStockData;
        private readonly StockDto _stockDto;

        public RetrieveDataFromApi(GetStockData getStockData, StockDto stockDto)
        {
            _getStockData = getStockData;
            _stockDto = stockDto;
        }

        public List<Model> getData(StockDto stockDto, string stockName)
        {
            List<Model> dtoList = _getStockData.RetrieveStockDataAsync(stockName).Result;
            return dtoList;
        }
    }

    public class FillTheDto
    {
        private readonly FillStockDto _fillStockDto;
        public FillTheDto(FillStockDto fillStockDto)
        {
            _fillStockDto = fillStockDto;
        }

        public void fillDto(string stockName, List<Model> theData)
        {
            _fillStockDto.FillTheDto(stockName, theData);
        }
    }
    
    public class PrintStockDatas
    {
        private readonly PrintStockData _printStockData;
        public PrintStockDatas(PrintStockData printStockData)
        {
            _printStockData = printStockData;
        }

        public void print(string stockName, List<Model> dataList)
        {
            _printStockData.printStockData(stockName,dataList);
        }

    }

}