

using WebtestAPI.Data;

namespace WebtestAPI.Service
{
    public interface IServiceProduct
    {
        Task<IEnumerable<DbProduct>> GetAllProduct();

    }
    

}
