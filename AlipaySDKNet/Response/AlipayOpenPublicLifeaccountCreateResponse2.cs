using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeaccountCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeaccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 生活号id
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 是否是重试请求
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
