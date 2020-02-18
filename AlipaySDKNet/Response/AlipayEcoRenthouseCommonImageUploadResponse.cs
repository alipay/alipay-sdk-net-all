using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoRenthouseCommonImageUploadResponse.
    /// </summary>
    public class AlipayEcoRenthouseCommonImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片url地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
