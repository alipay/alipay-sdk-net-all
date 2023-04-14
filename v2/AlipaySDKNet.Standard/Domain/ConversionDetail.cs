using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConversionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ConversionDetail : AopObject
    {
        /// <summary>
        /// 转化事件id
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化事件名称
        /// </summary>
        [XmlElement("conversion_name")]
        public string ConversionName { get; set; }

        /// <summary>
        /// 转化事件类型代码
        /// </summary>
        [XmlElement("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 转化事件类型名称
        /// </summary>
        [XmlElement("conversion_type_name")]
        public string ConversionTypeName { get; set; }

        /// <summary>
        /// 状态: ENABLE( "生效"); DISABLE( "失效"); DELETE("删除")
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
