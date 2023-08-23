using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletSignConsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletSignConsultResponse : AopResponse
    {
        /// <summary>
        /// 签约原始链接地址
        /// </summary>
        [XmlElement("original_url")]
        public string OriginalUrl { get; set; }

        /// <summary>
        /// 签约短链接地址
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// 签约结果
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
