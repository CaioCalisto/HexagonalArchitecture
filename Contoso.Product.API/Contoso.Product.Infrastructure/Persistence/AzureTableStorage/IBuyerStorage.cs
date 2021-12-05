using Azure.Data.Tables;

namespace Contoso.Product.Infrastructure.Persistence.AzureTableStorage
{
    public interface IBuyerStorage
    {
        TableEntity Add(TableEntity buyer);

        TableEntity Update(TableEntity buyer);

        Task<TableEntity> FindAsync(string partitionKey);

        Task<TableEntity> FindByIdAsync(string id);
    }
}
