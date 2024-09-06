using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly ApplicationDBContext _context;
        public PortfolioRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Protfolio> CreateAsync(Protfolio protfolio)
        {
            await _context.Protfolios.AddAsync(protfolio);
            await _context.SaveChangesAsync();
            return protfolio;


        }

        public async Task<Protfolio> DeletePortfolioAsync(AppUser appUser, string symbol)
        {
            var portfolioModel = await _context.Protfolios.FirstOrDefaultAsync(x => x.AppUserId == appUser.Id &&  x.Stock.Symbol.ToLower() == symbol.ToLower());

            if(portfolioModel == null)
            {
                return null;
            }

            _context.Protfolios.Remove(portfolioModel);
            await _context.SaveChangesAsync();

            return portfolioModel;
        }

        public async Task<List<Stock>> GetUserPortfolio(AppUser user)
        {
            return await _context.Protfolios.Where(u => u.AppUserId == user.Id)
            .Select(stock => new Stock
            {
                Id = stock.StockId,
                Symbol = stock.Stock.Symbol,
                CompanyName = stock.Stock.CompanyName,
                Purchase = stock.Stock.Purchase,
                LastDiv = stock.Stock.LastDiv,
                Industry = stock.Stock.Industry,
                MarketCap = stock.Stock.MarketCap
            }).ToListAsync();
        }
    }
}