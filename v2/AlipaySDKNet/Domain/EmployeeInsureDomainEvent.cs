using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeInsureDomainEvent Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeInsureDomainEvent : AopObject
    {
        /// <summary>
        /// 投保雇员主体信息
        /// </summary>
        [XmlElement("employee")]
        public InsureEmployee Employee { get; set; }

        /// <summary>
        /// 打卡事件地点
        /// </summary>
        [XmlElement("event_place")]
        public string EventPlace { get; set; }

        /// <summary>
        /// 事件发生时间点，在当前时间1小时范围内
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 事件类型，固定值
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant")]
        public InsureCompany Merchant { get; set; }

        /// <summary>
        /// 投保合作商信息，本次场景是和蚂蚁保签约的平台信息，固定值
        /// </summary>
        [XmlElement("partner_organization")]
        public InsurePartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 指定产品方案ID
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }
    }
}
