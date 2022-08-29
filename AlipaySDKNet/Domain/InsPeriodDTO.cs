using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsPeriodDTO : AopObject
    {
        /// <summary>
        /// 选项标签
        /// </summary>
        [XmlElement("option_tag")]
        public string OptionTag { get; set; }

        /// <summary>
        /// 期限数值
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 是否推荐
        /// </summary>
        [XmlElement("recommend")]
        public bool Recommend { get; set; }

        /// <summary>
        /// 期限单位：SECOND,MINUTE,HOUR,DAY,MONTH,YEAR
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
