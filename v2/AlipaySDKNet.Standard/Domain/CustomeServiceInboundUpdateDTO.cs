using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomeServiceInboundUpdateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomeServiceInboundUpdateDTO : AopObject
    {
        /// <summary>
        /// 废弃字段，文档不可见 当前字段已废弃(该字段已经被废弃，所有文档不可见)
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 事件动作
        /// </summary>
        [XmlElement("event_action")]
        public string EventAction { get; set; }

        /// <summary>
        /// 事件内容，所有的内容字段
        /// </summary>
        [XmlElement("event_content")]
        public string EventContent { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }

        /// <summary>
        /// 技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 技能组类型
        /// </summary>
        [XmlElement("skill_group_type")]
        public string SkillGroupType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("visitor_type")]
        public string VisitorType { get; set; }
    }
}
