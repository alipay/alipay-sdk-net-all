using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcInboundSeatEventModel Data Structure.
    /// </summary>
    [Serializable]
    public class IcInboundSeatEventModel : AopObject
    {
        /// <summary>
        /// 事件发生时间，1970年以来的毫秒数
        /// </summary>
        [XmlElement("event_time")]
        public long EventTime { get; set; }

        /// <summary>
        /// 坐席状态，如下： SEAT_ONLINE ：坐席上线 SEAT_OFFLINE：坐席下线 SEAT_OCCUPY：坐席资源占用 SEAT_RELEASE：坐席资源释放 SEAT_BREAK：坐席小休 SEAT_CANCEL_BREAK：坐席结束小休
        /// </summary>
        [XmlElement("seat_biz_action")]
        public string SeatBizAction { get; set; }

        /// <summary>
        /// 坐席当前负载，单位/个
        /// </summary>
        [XmlElement("seat_current_load")]
        public long SeatCurrentLoad { get; set; }

        /// <summary>
        /// 坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席ID类型
        /// </summary>
        [XmlElement("seat_id_type")]
        public string SeatIdType { get; set; }

        /// <summary>
        /// 坐席最大负载，单位/个
        /// </summary>
        [XmlElement("seat_max_load")]
        public long SeatMaxLoad { get; set; }

        /// <summary>
        /// 坐席服务状态
        /// </summary>
        [XmlElement("seat_service_status")]
        public string SeatServiceStatus { get; set; }

        /// <summary>
        /// 坐席签入渠道
        /// </summary>
        [XmlElement("seat_sign_channel")]
        public string SeatSignChannel { get; set; }

        /// <summary>
        /// 服务渠道
        /// </summary>
        [XmlElement("service_channel")]
        public string ServiceChannel { get; set; }

        /// <summary>
        /// 技能组ID类型
        /// </summary>
        [XmlElement("skill_group_id_type")]
        public string SkillGroupIdType { get; set; }

        /// <summary>
        /// 技能组ID列表
        /// </summary>
        [XmlArray("skill_group_ids")]
        [XmlArrayItem("string")]
        public List<string> SkillGroupIds { get; set; }

        /// <summary>
        /// 星云租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
