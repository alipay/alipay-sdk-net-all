using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetinsureSignurlQueryResponse.
    /// </summary>
    public class AlipayCommercePetinsureSignurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户签约地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
