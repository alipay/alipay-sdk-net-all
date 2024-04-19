using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BccSubjectDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BccSubjectDetail : AopObject
    {
        /// <summary>
        /// 标的完成值
        /// </summary>
        [XmlElement("completions")]
        public string Completions { get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        [XmlElement("current_value")]
        public string CurrentValue { get; set; }

        /// <summary>
        /// 该标的对应的事项
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 标的id
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 标的类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
