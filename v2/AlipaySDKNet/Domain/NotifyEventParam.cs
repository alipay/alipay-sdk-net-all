using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotifyEventParam Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyEventParam : AopObject
    {
        /// <summary>
        /// 事件类型对应配置
        /// </summary>
        [XmlElement("event_config")]
        public string EventConfig { get; set; }

        /// <summary>
        /// 代表要发送的消息事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 跳转用户页面
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 用户打卡的时间毫秒数
        /// </summary>
        [XmlElement("punch_time")]
        public string PunchTime { get; set; }

        /// <summary>
        /// 需要跳转的appid
        /// </summary>
        [XmlElement("target_app_id")]
        public string TargetAppId { get; set; }

        /// <summary>
        /// 工作时长，精确到分钟。如工作10个小时，则传600。
        /// </summary>
        [XmlElement("work_time")]
        public string WorkTime { get; set; }
    }
}
