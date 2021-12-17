namespace Contoso.Product.Application.Queries
{
    public interface IBuyerQueries
    {
        ValueTask<Buyer> GetBuyer(Guid id);

        ValueTask<Buyer> GetBuyer(string buyerName);
    }
}
