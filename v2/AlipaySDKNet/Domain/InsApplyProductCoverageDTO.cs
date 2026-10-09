using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsApplyProductCoverageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsApplyProductCoverageDTO : AopObject
    {
        /// <summary>
        /// 止期
        /// </summary>
        [XmlElement("effective_end_time")]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// 起期
        /// </summary>
        [XmlElement("effective_start_time")]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// 保期 1M，一个月 3M，三个月
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }
    }
}
