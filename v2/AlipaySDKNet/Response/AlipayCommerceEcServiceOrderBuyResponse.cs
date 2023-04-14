using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderBuyResponse.
    /// </summary>
    public class AlipayCommerceEcServiceOrderBuyResponse : AopResponse
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 需要跳转企业码签约的订购，会返回签约地址
        /// </summary>
        [XmlElement("sign_contract_url")]
        public string SignContractUrl { get; set; }
    }
}
