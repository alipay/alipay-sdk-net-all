using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RatePlan Data Structure.
    /// </summary>
    [Serializable]
    public class RatePlan : AopObject
    {
        /// <summary>
        /// 对应的预订规则编号列表 多个同时满足条件默认选第一个规则
        /// </summary>
        [XmlArray("booking_rule_ids")]
        [XmlArrayItem("string")]
        public List<string> BookingRuleIds { get; set; }

        /// <summary>
        /// 平均确认时长分钟数，IsInstantConfirm 为false时需传该值
        /// </summary>
        [XmlElement("confirm_minutes")]
        public long ConfirmMinutes { get; set; }

        /// <summary>
        /// 客人类型 All:统一价 DOMESTIC：内宾 FOREIGNER：外宾
        /// </summary>
        [XmlElement("customer_type")]
        public string CustomerType { get; set; }

        /// <summary>
        /// 证件数量类型：       0：无特殊要求（下单不用证件）      *1：整个订单需一个证件      *2：订单中每个房间需一个证件
        /// </summary>
        [XmlElement("identification")]
        public long Identification { get; set; }

        /// <summary>
        /// 需要的证件类型，多个值标识任意一种证件类型都可以,枚举值见下： IDENTITY_CARD: 身份证 PASSPORT:护照
        /// </summary>
        [XmlArray("identification_type")]
        [XmlArrayItem("string")]
        public List<string> IdentificationType { get; set; }

        /// <summary>
        /// 是否即时确认
        /// </summary>
        [XmlElement("instant_confirmation")]
        public bool InstantConfirmation { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice")]
        public HotelInvoice Invoice { get; set; }

        /// <summary>
        /// 每日价格列表
        /// </summary>
        [XmlArray("nightly_rates")]
        [XmlArrayItem("nightly_rate")]
        public List<NightlyRate> NightlyRates { get; set; }

        /// <summary>
        /// 对应ota小程序的跳转链接
        /// </summary>
        [XmlElement("ota_url")]
        public string OtaUrl { get; set; }

        /// <summary>
        /// 付款类型 SELFPAY-前台现付, PREPAY-预付
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 价格计划id
        /// </summary>
        [XmlElement("rate_plan_id")]
        public string RatePlanId { get; set; }

        /// <summary>
        /// 价格计划标签列表
        /// </summary>
        [XmlArray("rate_plan_labels")]
        [XmlArrayItem("rate_plan_label")]
        public List<RatePlanLabel> RatePlanLabels { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("rate_plan_name")]
        public string RatePlanName { get; set; }

        /// <summary>
        /// 对应退款规则编号
        /// </summary>
        [XmlElement("refund_rule_id")]
        public string RefundRuleId { get; set; }

        /// <summary>
        /// 退款规则列表
        /// </summary>
        [XmlArray("refund_rule_ids")]
        [XmlArrayItem("string")]
        public List<string> RefundRuleIds { get; set; }

        /// <summary>
        /// ratePlan对应的房间id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 销售状态 true:在售 false:失效
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }

        /// <summary>
        /// 供应商信息
        /// </summary>
        [XmlElement("supplier_source")]
        public string SupplierSource { get; set; }
    }
}
