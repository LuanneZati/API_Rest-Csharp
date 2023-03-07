using API_Rest.Models;

namespace API_Rest.Services.ApiRest
{
    public interface IApiRest
    {
        List<ApiRestClass>? GetAllResults();
        ApiRestClass? GetSingleResult(int id);
        List<ApiRestClass>? AddData(ApiRestClass data);
        List<ApiRestClass>? UpdateResult(int id, ApiRestClass request);
        List<ApiRestClass>? DeleteResult(int id);

    }
}
