using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Payments.PayPalExpressCheckout.Models
{
    public class PaymentInfoModel : BaseNopModel
    {
        public string MerchantId { get; set; }
        public bool IsLive { get; set; }
    }
}