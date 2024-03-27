using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomeServiceInboundCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomeServiceInboundCreateDTO : AopObject
    {
        /// <summary>
        /// 业务包code
        /// </summary>
        [XmlElement("biz_package_code")]
        public string BizPackageCode { get; set; }

        /// <summary>
        /// tntInstId 与channelId二选一。优先使用tntInstId
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 转接前的坐席id
        /// </summary>
        [XmlElement("origin_seat_id")]
        public string OriginSeatId { get; set; }

        /// <summary>
        /// 转接前的服务唯一标识
        /// </summary>
        [XmlElement("origin_service_uniq_code")]
        public string OriginServiceUniqCode { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 转接指定坐席id
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 转接坐席类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }

        /// <summary>
        /// 服务唯一标识。发生转接需要生成新的唯一标识 --> requestId
        /// </summary>
        [XmlElement("service_uniq_code")]
        public string ServiceUniqCode { get; set; }

        /// <summary>
        /// 转接指定技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 技能组类型
        /// </summary>
        [XmlElement("skill_group_type")]
        public string SkillGroupType { get; set; }

        /// <summary>
        /// 访客ID，REALID类型为2088，2066账号ID等，ANONYMOUS为88888888
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// 模式类型
        /// </summary>
        [XmlElement("visitor_mode")]
        public string VisitorMode { get; set; }

        /// <summary>
        /// 访客类型
        /// </summary>
        [XmlElement("visitor_type")]
        public string VisitorType { get; set; }
    }
}
