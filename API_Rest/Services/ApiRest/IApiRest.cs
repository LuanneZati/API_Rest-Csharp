using API_Rest.Models;

namespace API_Rest.Services.ApiRest
{
    public interface IApiRest
    {
        Task<List<ApiRestClass>> GetAllResults();
        Task<ApiRestClass?> GetSingleResult(int id);
        Task<List<ApiRestClass>?> AddData(ApiRestClass data);
        Task<List<ApiRestClass>?> UpdateResult(int id, ApiRestClass request);
        Task<List<ApiRestClass>?> DeleteResult(int id);

    }
}
