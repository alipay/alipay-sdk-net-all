using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RealtimeTextQc Data Structure.
    /// </summary>
    [Serializable]
    public class RealtimeTextQc : AopObject
    {
        /// <summary>
        /// 当前时间
        /// </summary>
        [XmlElement("current_time")]
        public string CurrentTime { get; set; }

        /// <summary>
        /// 用于表示唯一请求单句话唯一标识 6位数字,前序不足的数位补0
        /// </summary>
        [XmlElement("dialog_id")]
        public string DialogId { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 服务来源，枚举，会影响质检适用的规则
        /// </summary>
        [XmlElement("service_source")]
        public string ServiceSource { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 当前待检文本角色
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
