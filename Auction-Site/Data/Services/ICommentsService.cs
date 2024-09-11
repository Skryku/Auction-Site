using Auction_Site.Models;

namespace Auction_Site.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
