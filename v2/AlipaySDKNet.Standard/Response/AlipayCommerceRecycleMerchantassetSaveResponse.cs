using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleMerchantassetSaveResponse.
    /// </summary>
    public class AlipayCommerceRecycleMerchantassetSaveResponse : AopResponse
    {
        /// <summary>
        /// 商户授权链接，在pc打开该链接，并使用商户账号完成授权
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
