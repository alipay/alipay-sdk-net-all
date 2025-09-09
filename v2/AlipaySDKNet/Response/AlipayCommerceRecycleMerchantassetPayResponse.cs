using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleMerchantassetPayResponse.
    /// </summary>
    public class AlipayCommerceRecycleMerchantassetPayResponse : AopResponse
    {
        /// <summary>
        /// 充值链接，在pc打开该链接，并使用商户账号完成充值
        /// </summary>
        [XmlElement("pay_link")]
        public string PayLink { get; set; }
    }
}
