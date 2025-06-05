using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowAccountauthApplyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowAccountauthApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约地址url
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
