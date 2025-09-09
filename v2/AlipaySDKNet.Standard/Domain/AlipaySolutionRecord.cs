using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySolutionRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySolutionRecord : AopObject
    {
        /// <summary>
        /// 数据记录字段的key
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 数据记录字段的值
        /// </summary>
        [XmlElement("data_value")]
        public string DataValue { get; set; }
    }
}
