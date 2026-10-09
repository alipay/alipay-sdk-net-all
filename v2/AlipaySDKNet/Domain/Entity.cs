using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Entity Data Structure.
    /// </summary>
    [Serializable]
    public class Entity : AopObject
    {
        /// <summary>
        /// 详情id
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 病例类型
        /// </summary>
        [XmlElement("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease")]
        public string Disease { get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }
    }
}
