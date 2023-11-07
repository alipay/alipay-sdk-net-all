using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantCreateResponse.
    /// </summary>
    public class AlipayCommerceIndirectmerchantCreateResponse : AopResponse
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
