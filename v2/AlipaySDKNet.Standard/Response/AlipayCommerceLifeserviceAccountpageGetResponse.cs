using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceAccountpageGetResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceAccountpageGetResponse : AopResponse
    {
        /// <summary>
        /// 充值链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
