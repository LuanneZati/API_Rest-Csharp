﻿namespace API_Rest.Services.ApiRest
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
        private readonly DataContext _context;
        public ApiRestService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ApiRestClass>?> AddData(ApiRestClass data)
        {
            _context.MyData.Add(data);
            await _context.SaveChangesAsync();
            return results;
        }

        public async Task<List<ApiRestClass>?> DeleteResult(int id)
        {
            var single = await _context.MyData.FindAsync(id);
            if (single == null)
                return null;

            _context.MyData.Remove(single);
            await _context.SaveChangesAsync();

            return results;
        }

        public async Task<List<ApiRestClass>> GetAllResults()
        {
            var data = await _context.MyData.ToListAsync();
            return data;
        }

        public async Task<ApiRestClass?> GetSingleResult(int id)
        {
            var single = await _context.MyData.FindAsync(id);
            if (single == null)
                return null;
            return single;
        }

        public async Task<List<ApiRestClass>?> UpdateResult(int id, ApiRestClass request)
        {
            var single = await _context.MyData.FindAsync(id);
            if (single == null)
                return null;
            single.FirstName = request.FirstName;
            single.LastName = request.LastName;
            single.PlaceName = request.PlaceName;
            single.Name = request.Name;

            await _context.SaveChangesAsync();

            return results;
        }
    }
}
