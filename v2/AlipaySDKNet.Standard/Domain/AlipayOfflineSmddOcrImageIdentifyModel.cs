using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddOcrImageIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddOcrImageIdentifyModel : AopObject
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("afts_url")]
        public string AftsUrl { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        [XmlElement("ocr_type")]
        public string OcrType { get; set; }
    }
}
