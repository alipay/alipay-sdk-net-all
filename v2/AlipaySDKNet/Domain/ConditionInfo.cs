using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConditionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConditionInfo : AopObject
    {
        /// <summary>
        /// 条件表达式标识，用于标识表达式
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 操作符，可选值：AND - 并条件；OR - 或条件；NOT - 非条件
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 条件优先级，数字越小表示优先级越高，从1开始
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 标签信息列表，AND 和 OR 条件可对应多个，NOT条件只允许一个值
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("tag_info")]
        public List<TagInfo> TagList { get; set; }
    }
}
