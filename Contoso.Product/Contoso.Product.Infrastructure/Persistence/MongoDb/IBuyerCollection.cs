using MongoDB.Bson;

namespace Contoso.Product.Infrastructure.Persistence.MongoDb
{
    public interface IBuyerCollection
    {
        BsonDocument Add(BsonDocument buyer);

        BsonDocument Update(BsonDocument buyer);

        Task<BsonDocument> FindAsync(string BuyerIdentityGuid);

        Task<BsonDocument> FindByIdAsync(string id);
    }
}
