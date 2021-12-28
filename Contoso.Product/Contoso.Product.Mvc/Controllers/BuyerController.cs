using System.Diagnostics;
using Contoso.Product.Mvc.Models;
using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Product.Mvc.Controllers
{
    public class BuyerController : Controller
    {
        private readonly ILogger<BuyerController> _logger;
        private readonly IAddPaymentInput addPaymentInput;
        private readonly AbstractionAddPaymentOutput addPaymentOutput;

        public BuyerController(
            ILogger<BuyerController> logger,
            IAddPaymentInput addPaymentInput,
            AbstractionAddPaymentOutput addPaymentOutput)
        {
            _logger = logger;
            this.addPaymentInput = addPaymentInput;
            this.addPaymentOutput = addPaymentOutput;
        }

        public IActionResult AddPaymentMethod()
        {
            this.addPaymentOutput.OnNotified += this.NotifyViewModel;

            this.addPaymentInput.AddPaymentMethod(new UseCases.Buyer.Inputs.AddPaymentMethod(
                0,
                0,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                new DateTime(),
                0));
            return View();

        }

        private void NotifyViewModel(string msg)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}