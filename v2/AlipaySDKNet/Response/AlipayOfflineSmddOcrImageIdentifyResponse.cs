using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddOcrImageIdentifyResponse.
    /// </summary>
    public class AlipayOfflineSmddOcrImageIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 解析结果
        /// </summary>
        [XmlElement("ocr_data")]
        public string OcrData { get; set; }
    }
}
