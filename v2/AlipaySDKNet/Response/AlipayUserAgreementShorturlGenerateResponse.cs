using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementShorturlGenerateResponse.
    /// </summary>
    public class AlipayUserAgreementShorturlGenerateResponse : AopResponse
    {
        /// <summary>
        /// 原始签约长链接经过转换后得到的短链
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }
    }
}
