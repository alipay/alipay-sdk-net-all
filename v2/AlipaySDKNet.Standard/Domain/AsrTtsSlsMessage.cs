using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AsrTtsSlsMessage Data Structure.
    /// </summary>
    [Serializable]
    public class AsrTtsSlsMessage : AopObject
    {
        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 会话开始时间
        /// </summary>
        [XmlElement("call_session_start_time")]
        public long CallSessionStartTime { get; set; }

        /// <summary>
        /// 当前设备id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 音转文内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 设备通话开始时间（接听时间）
        /// </summary>
        [XmlElement("device_session_start_time")]
        public long DeviceSessionStartTime { get; set; }

        /// <summary>
        /// 当前设备类型：0:机器人 1:坐席,2:客户
        /// </summary>
        [XmlElement("device_type")]
        public long DeviceType { get; set; }

        /// <summary>
        /// 结束时间，同start_time对应
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 是否被打断
        /// </summary>
        [XmlElement("interrupted")]
        public bool Interrupted { get; set; }

        /// <summary>
        /// 序列号，展示顺序
        /// </summary>
        [XmlElement("seq")]
        public long Seq { get; set; }

        /// <summary>
        /// 当前时间戳
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }
    }
}
