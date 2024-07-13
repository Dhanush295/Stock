using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Dtos.StockDtos;
using api.Model;

namespace api.Mapper
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel )
        {
            return new StockDto {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                Dividend = stockModel.Dividend,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
            };
        } 

        public static Stock ToStockFromCreateDto(this CreateStockRequestDto stockDto)
        {
            return new Stock {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                Dividend = stockDto.Dividend,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap,
            };
        }
    }
}