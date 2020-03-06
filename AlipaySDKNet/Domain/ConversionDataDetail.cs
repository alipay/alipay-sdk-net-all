using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConversionDataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ConversionDataDetail : AopObject
    {
        /// <summary>
        /// 转化事件id
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化事件结果
        /// </summary>
        [XmlElement("conversion_result")]
        public string ConversionResult { get; set; }
    }
}
