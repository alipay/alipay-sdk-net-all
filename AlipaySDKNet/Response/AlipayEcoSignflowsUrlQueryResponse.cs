using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoSignflowsUrlQueryResponse.
    /// </summary>
    public class AlipayEcoSignflowsUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 预览短链地址（30天有效）
        /// </summary>
        [XmlElement("preview_short_url")]
        public string PreviewShortUrl { get; set; }

        /// <summary>
        /// 预览长链地址(永久有效)
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 签署短链地址（30天有效）
        /// </summary>
        [XmlElement("sign_short_url")]
        public string SignShortUrl { get; set; }

        /// <summary>
        /// 签署长链地址(永久有效)
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
