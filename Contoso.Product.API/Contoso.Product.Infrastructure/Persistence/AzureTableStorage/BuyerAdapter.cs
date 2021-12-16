using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Product.Domain.Aggregates.Buyers;
using Contoso.Product.Infrastructure.Persistence;

namespace Contoso.Product.Infrastructure.Persistence.AzureTableStorage
{
    public class BuyerAdapter : IBuyerRepository
    {
        private readonly IBuyerStorage tableStorage;

        public BuyerAdapter(IBuyerStorage tableStorage)
        {
            this.tableStorage = tableStorage;
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Buyer Add(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer> FindAsync(string BuyerIdentityGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Buyer Update(Buyer buyer)
        {
            throw new NotImplementedException();
        }
    }
}
