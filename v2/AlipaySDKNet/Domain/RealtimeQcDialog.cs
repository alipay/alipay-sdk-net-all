using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RealtimeQcDialog Data Structure.
    /// </summary>
    [Serializable]
    public class RealtimeQcDialog : AopObject
    {
        /// <summary>
        /// Long类型
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 唯一标识一句话
        /// </summary>
        [XmlElement("dialog_id")]
        public string DialogId { get; set; }

        /// <summary>
        /// 对话文本所属角色
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 会话文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
