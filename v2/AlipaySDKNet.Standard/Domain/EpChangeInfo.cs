using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpChangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpChangeInfo : AopObject
    {
        /// <summary>
        /// 订阅的变更监听项
        /// </summary>
        [XmlElement("change_field_code")]
        public string ChangeFieldCode { get; set; }

        /// <summary>
        /// 变更监听项的中文描述
        /// </summary>
        [XmlElement("change_field_desc")]
        public string ChangeFieldDesc { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 变更后信息
        /// </summary>
        [XmlElement("new_value")]
        public string NewValue { get; set; }

        /// <summary>
        /// 变更前信息
        /// </summary>
        [XmlElement("old_value")]
        public string OldValue { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
