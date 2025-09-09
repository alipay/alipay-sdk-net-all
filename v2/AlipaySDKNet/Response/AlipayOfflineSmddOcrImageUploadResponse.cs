using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddOcrImageUploadResponse.
    /// </summary>
    public class AlipayOfflineSmddOcrImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 该地址用于OCR识别
        /// </summary>
        [XmlElement("afts_url")]
        public string AftsUrl { get; set; }
    }
}
