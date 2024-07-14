using Interview.Models;

namespace Interview.Repository
{
    public class UnitRepository : IGeneralRepository<Unit>
    {
        /* the rest of function will implement later*/
        public Task Add(Unit obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Unit>> GetAll()
        {
            HttpClient client = new HttpClient();
            List<Unit>? units =
                 await client.GetFromJsonAsync<List<Unit>>("http://appydev-001-site2.atempurl.com/Unit");
            return units;
        }

        public Unit GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Unit obj)
        {
            throw new NotImplementedException();
        }
    }
}
