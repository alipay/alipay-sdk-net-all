using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeAcpShortenurlQueryResponse.
    /// </summary>
    public class ZhimaCreditPeAcpShortenurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 转换后的短链
        /// </summary>
        [XmlElement("shorten_url")]
        public string ShortenUrl { get; set; }
    }
}
