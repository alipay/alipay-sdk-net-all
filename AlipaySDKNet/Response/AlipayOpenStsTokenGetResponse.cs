using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenStsTokenGetResponse.
    /// </summary>
    public class AlipayOpenStsTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 安全令牌失效时间（1970年1月1日00:00:00开始算起的毫秒数）
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 安全令牌
        /// </summary>
        [XmlElement("security_token")]
        public string SecurityToken { get; set; }
    }
}
