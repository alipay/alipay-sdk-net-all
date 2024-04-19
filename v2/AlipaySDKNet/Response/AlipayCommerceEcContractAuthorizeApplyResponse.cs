using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcContractAuthorizeApplyResponse.
    /// </summary>
    public class AlipayCommerceEcContractAuthorizeApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约授权地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
