using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolVisitordispatchSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolVisitordispatchSubmitModel : AopObject
    {
        /// <summary>
        /// 业务包code
        /// </summary>
        [XmlElement("biz_package_code")]
        public string BizPackageCode { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道id
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 其他信息。如小二的身份标签、用户诉求，问题类目，标准问题
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 转接前的坐席ID
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
        /// 队列优先级
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 转接坐席ID
        /// </summary>
        [XmlElement("seat_id")]
        public string SeatId { get; set; }

        /// <summary>
        /// 坐席类型
        /// </summary>
        [XmlElement("seat_type")]
        public string SeatType { get; set; }

        /// <summary>
        /// 服务唯一标识
        /// </summary>
        [XmlElement("service_uniq_code")]
        public string ServiceUniqCode { get; set; }

        /// <summary>
        /// 转接技能组id
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// 转接技能组类型：工作台技能组 CLIVE_GROUP
        /// </summary>
        [XmlElement("skill_group_type")]
        public string SkillGroupType { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 访客ID，REALID类型为2066等。ANONYMOUSE类型为88888888
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
