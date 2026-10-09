using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdReportConversionDataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AdReportConversionDataDetail : AopObject
    {
        /// <summary>
        /// 转化事件结果
        /// </summary>
        [XmlElement("conversion_result")]
        public string ConversionResult { get; set; }

        /// <summary>
        /// 转化事件类型
        /// </summary>
        [XmlElement("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 转化事件类型名称
        /// </summary>
        [XmlElement("conversion_type_name")]
        public string ConversionTypeName { get; set; }
    }
}
