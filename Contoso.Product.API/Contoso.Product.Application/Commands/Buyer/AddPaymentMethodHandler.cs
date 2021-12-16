using Contoso.Product.Infrastructure.Persistence;

namespace Contoso.Product.Application.Commands.Buyer
{
    public class AddPaymentMethodHandler : IAddPaymentMethodHandler
    {
        private readonly IBuyerRepository buyerRepository;

        public AddPaymentMethodHandler(IBuyerRepository buyerRepository)
        {
            this.buyerRepository = buyerRepository;
        }

        public Task AddPaymentMethod(AddPaymentMethod addPaymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
