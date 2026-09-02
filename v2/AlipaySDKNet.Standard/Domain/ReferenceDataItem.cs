using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReferenceDataItem Data Structure.
    /// </summary>
    [Serializable]
    public class ReferenceDataItem : AopObject
    {
        /// <summary>
        /// 年龄段: 1=0-7岁, 2=7-18岁
        /// </summary>
        [XmlElement("age_group")]
        public long AgeGroup { get; set; }

        /// <summary>
        /// 性别: 1=男, 2=女
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 参考数据JSON
        /// </summary>
        [XmlElement("reference_data")]
        public string ReferenceData { get; set; }

        /// <summary>
        /// 数值类型: PERCENTILE, THRESHOLD
        /// </summary>
        [XmlElement("value_type")]
        public string ValueType { get; set; }
    }
}
