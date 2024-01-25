using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OcrData Data Structure.
    /// </summary>
    [Serializable]
    public class OcrData : AopObject
    {
        /// <summary>
        /// ocr按业务类型返回的字段key
        /// </summary>
        [XmlElement("ocr_data_key")]
        public string OcrDataKey { get; set; }

        /// <summary>
        /// ocr识别出来的内容
        /// </summary>
        [XmlElement("ocr_data_value")]
        public string OcrDataValue { get; set; }
    }
}
