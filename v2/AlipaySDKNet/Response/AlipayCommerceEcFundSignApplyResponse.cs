using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcFundSignApplyResponse.
    /// </summary>
    public class AlipayCommerceEcFundSignApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约链接
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }
    }
}
