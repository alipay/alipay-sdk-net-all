using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsLGBDomainEvent Data Structure.
    /// </summary>
    [Serializable]
    public class InsLGBDomainEvent : AopObject
    {
        /// <summary>
        /// 员工信息
        /// </summary>
        [XmlElement("employee")]
        public InsEmployee Employee { get; set; }

        /// <summary>
        /// 打卡事件地点
        /// </summary>
        [XmlElement("event_place")]
        public string EventPlace { get; set; }

        /// <summary>
        /// 事件发生时间点
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant")]
        public InsCompany Merchant { get; set; }

        /// <summary>
        /// 合作商信息
        /// </summary>
        [XmlElement("partner_organization")]
        public InsPartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 指定产品方案ID
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }
    }
}
