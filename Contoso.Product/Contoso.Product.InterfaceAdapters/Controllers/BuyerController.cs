using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.InterfaceAdapters.Controllers
{
    public class BuyerController : IAddPaymentInput
    {
        public BuyerController()
        {

        }

        public ValueTask<Buyer> AddPaymentMethod(AddPaymentMethod addPaymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
