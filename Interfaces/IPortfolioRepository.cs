using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using API.Models;

namespace API.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(AppUser user);

        Task<Protfolio> CreateAsync(Protfolio protfolio);

        Task<Protfolio> DeletePortfolioAsync(AppUser appUser, string symbol);
    }
}