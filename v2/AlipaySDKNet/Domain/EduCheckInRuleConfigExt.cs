using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduCheckInRuleConfigExt Data Structure.
    /// </summary>
    [Serializable]
    public class EduCheckInRuleConfigExt : AopObject
    {
        /// <summary>
        /// 结束分钟
        /// </summary>
        [XmlElement("end_minutes")]
        public long EndMinutes { get; set; }

        /// <summary>
        /// 结束类型
        /// </summary>
        [XmlElement("end_type")]
        public string EndType { get; set; }

        /// <summary>
        /// 开始分钟
        /// </summary>
        [XmlElement("start_minutes")]
        public long StartMinutes { get; set; }

        /// <summary>
        /// 开始类型
        /// </summary>
        [XmlElement("start_type")]
        public string StartType { get; set; }
    }
}
