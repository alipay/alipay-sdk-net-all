using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBenefitStatusCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBenefitStatusCallbackModel : AopObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益实例id
        /// </summary>
        [XmlElement("benefit_instance_id")]
        public string BenefitInstanceId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 券核销订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 计划拥有者id
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 活动联营计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 权益状态，RECEIVED、USED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
