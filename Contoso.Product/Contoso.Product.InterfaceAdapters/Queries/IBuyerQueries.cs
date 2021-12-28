namespace Contoso.Product.InterfaceAdapters.Queries
{
    public interface IBuyerQueries
    {
        ValueTask<Output.Buyer> GetBuyer(Guid id);

        ValueTask<Output.Buyer> GetBuyer(string buyerName);
    }
}
