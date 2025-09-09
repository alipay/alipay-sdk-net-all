using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditBusinessPlanCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditBusinessPlanCreateModel : AopObject
    {
        /// <summary>
        /// 商户订单号。 商家自定义需保证在商户端不重复。仅支持字母、数字、下划线。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 计划信息
        /// </summary>
        [XmlElement("plan_info")]
        public CreditPerformancePlanInfoOpen PlanInfo { get; set; }

        /// <summary>
        /// 履约计划模式
        /// </summary>
        [XmlElement("plan_mode")]
        public string PlanMode { get; set; }

        /// <summary>
        /// 履约计划子模式
        /// </summary>
        [XmlElement("plan_sub_mode")]
        public string PlanSubMode { get; set; }

        /// <summary>
        /// 日、周、月、季分期模式时间传输需要按照对应的时间间隔传输。
        /// </summary>
        [XmlElement("plan_type")]
        public string PlanType { get; set; }

        /// <summary>
        /// 产品标识，按枚举填入。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
