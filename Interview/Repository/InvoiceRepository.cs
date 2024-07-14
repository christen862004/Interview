using Interview.Models;

namespace Interview.Repository
{
    public class InvoiceRepository : IGeneralRepository<InvoiceDetail>
    {
        public async Task Add(InvoiceDetail obj)
        {
            HttpClient client = new HttpClient();
            await  client.PostAsJsonAsync<InvoiceDetail>("http://appydev-001-site2.atempurl.com/InvoiceDetail", obj);
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InvoiceDetail>> GetAll()
        {
            HttpClient client = new HttpClient();
            List<InvoiceDetail>? Invoices =
                 await client.GetFromJsonAsync<List<InvoiceDetail>>("http://appydev-001-site2.atempurl.com/InvoiceDetail");
            return Invoices;
        }

        public InvoiceDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(InvoiceDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
