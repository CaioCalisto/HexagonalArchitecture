using MongoDB.Bson;

namespace Contoso.Product.Infrastructure.Persistence.MongoDb
{
    public class BuyerCollection : IBuyerCollection
    {
        public BsonDocument Add(BsonDocument buyer)
        {
            throw new NotImplementedException();
        }

        public Task<BsonDocument> FindAsync(string BuyerIdentityGuid)
        {
            throw new NotImplementedException();
        }

        public Task<BsonDocument> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public BsonDocument Update(BsonDocument buyer)
        {
            throw new NotImplementedException();
        }
    }
}
