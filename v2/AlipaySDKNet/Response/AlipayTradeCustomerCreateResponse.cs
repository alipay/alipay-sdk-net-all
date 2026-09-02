using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCustomerCreateResponse.
    /// </summary>
    public class AlipayTradeCustomerCreateResponse : AopResponse
    {
        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 商家入参传入的幂等号。若未传入，支付宝将自动生成AUTO_开头的随机幂等号
        /// </summary>
        [XmlElement("merchant_request_no")]
        public string MerchantRequestNo { get; set; }
    }
}
