using Azure.Data.Tables;

namespace Contoso.Product.Infrastructure.Persistence.AzureTableStorage
{
    public class BuyerStorage : IBuyerStorage
    {
        public TableEntity Add(TableEntity buyer)
        {
            throw new NotImplementedException();
        }

        public Task<TableEntity> FindAsync(string partitionKey)
        {
            throw new NotImplementedException();
        }

        public Task<TableEntity> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public TableEntity Update(TableEntity buyer)
        {
            throw new NotImplementedException();
        }
    }
}
