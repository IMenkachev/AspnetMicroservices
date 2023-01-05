using Shopping.Aggregator.Models;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services
{
    public interface IBasketService
    {
        public Task<BasketModel> GetBasket(string userName);
    }
}
