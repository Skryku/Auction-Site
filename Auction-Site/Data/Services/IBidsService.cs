using Auction_Site.Models;

namespace Auction_Site.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
