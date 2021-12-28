namespace Contoso.Product.UseCases.Queries
{
    public interface IBuyerQueries
    {
        ValueTask<Output.Buyer> GetBuyer(Guid id);

        ValueTask<Output.Buyer> GetBuyer(string buyerName);
    }
}
