using Shopping.Aggregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services
{
    public interface ICatalogService
    {
        public Task<IEnumerable<CatalogModel>> GetCatalog();
        public Task<CatalogModel> GetCatalog(string id);
        public Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category);
    }
}
