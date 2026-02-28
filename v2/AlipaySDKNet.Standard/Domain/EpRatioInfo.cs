using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpRatioInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpRatioInfo : AopObject
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("crn")]
        public string Crn { get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 持股比例
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }
    }
}
