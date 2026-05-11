using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailPromoactivitySaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailPromoactivitySaveModel : AopObject
    {
        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("base_info")]
        public string BaseInfo { get; set; }

        /// <summary>
        /// 权益
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 投放规则
        /// </summary>
        [XmlElement("delivery_rule")]
        public string DeliveryRule { get; set; }

        /// <summary>
        /// 发放规则
        /// </summary>
        [XmlElement("grant_rule")]
        public string GrantRule { get; set; }

        /// <summary>
        /// 限制规则
        /// </summary>
        [XmlElement("limit_rule")]
        public string LimitRule { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 展示规则
        /// </summary>
        [XmlElement("show_rule")]
        public string ShowRule { get; set; }
    }
}
