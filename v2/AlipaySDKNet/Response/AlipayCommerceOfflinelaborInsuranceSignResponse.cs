using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceSignResponse.
    /// </summary>
    public class AlipayCommerceOfflinelaborInsuranceSignResponse : AopResponse
    {
        /// <summary>
        /// 企业支付宝签约页面链接
        /// </summary>
        [XmlElement("sign_page_url")]
        public string SignPageUrl { get; set; }
    }
}
