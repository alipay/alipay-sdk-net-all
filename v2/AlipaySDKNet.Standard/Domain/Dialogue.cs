using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Dialogue Data Structure.
    /// </summary>
    [Serializable]
    public class Dialogue : AopObject
    {
        /// <summary>
        /// 开始时间，相对（毫秒）
        /// </summary>
        [XmlElement("begin")]
        public long Begin { get; set; }

        /// <summary>
        /// 结束时间，相对（毫秒）
        /// </summary>
        [XmlElement("end")]
        public long End { get; set; }

        /// <summary>
        /// 对话下标位置，对话标识
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// 客服/客户 对话角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 对话内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
