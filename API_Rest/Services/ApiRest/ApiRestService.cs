namespace API_Rest.Services.ApiRest
{
    public class ApiRestService : IApiRest
    {
        private static List<ApiRestClass> results = new List<ApiRestClass>()
        {
            new ApiRestClass{Id= 1,
                Name="Spider Man",
                FirstName="Peter",
                LastName="Parker",
                PlaceName="New York City"
            },
            new ApiRestClass{Id= 2,
                Name="Iron Man",
                FirstName="Tony",
                LastName="Stark",
                PlaceName="Malibu City"
            }
        };

        public List<ApiRestClass> AddData(ApiRestClass data)
        {
            results.Add(data);
            return results;
        }

        public List<ApiRestClass>? DeleteResult(int id)
        {
            var single = results.Find(x => x.Id == id);
            if (single == null)
                return null;

            results.Remove(single);

            return results;
        }

        public List<ApiRestClass> GetAllResults()
        {
            return results;
        }

        public ApiRestClass? GetSingleResult(int id)
        {
            var single = results.Find(x => x.Id == id);
            if (single == null)
                return null;
            return single;
        }

        public List<ApiRestClass>? UpdateResult(int id, ApiRestClass request)
        {
            var single = results.Find(x => x.Id == id);
            if (single == null)
                return null;
            single.FirstName = request.FirstName;
            single.LastName = request.LastName;
            single.PlaceName = request.PlaceName;
            single.Name = request.Name;

            return results;
        }
    }
}
