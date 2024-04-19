using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderBindResponse.
    /// </summary>
    public class AlipayCommerceEcServiceOrderBindResponse : AopResponse
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约地址
        /// </summary>
        [XmlElement("sign_contract_url")]
        public string SignContractUrl { get; set; }
    }
}
