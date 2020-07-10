using Newtonsoft.Json;

namespace Inorsoft.Base.MultiTenancy.Payments.Paypal
{
    public class PayPalExecutePaymentRequest
    {
        [JsonProperty("payer_id")]
        public string PayerId { get; set; }

        public PayPalExecutePaymentRequest(string payerId)
        {
            PayerId = payerId;
        }
    }
}