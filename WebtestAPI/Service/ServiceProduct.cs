

using Microsoft.EntityFrameworkCore;
using WebtestAPI.Context;
using WebtestAPI.Data;

namespace WebtestAPI.Service
{
    public class ServiceProduct : IServiceProduct
    {
        public readonly TestApiContext _context;
        public ServiceProduct(TestApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DbProduct>> GetAllProduct()
        {
            var result = await _context.products.ToListAsync();
            return result;
        }
    }
}
