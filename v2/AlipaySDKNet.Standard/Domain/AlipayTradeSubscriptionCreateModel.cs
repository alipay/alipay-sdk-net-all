using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionCreateModel : AopObject
    {
        /// <summary>
        /// 客户id，客户创建接口（alipay.trade.customer.create）返回的客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 有限枚举，托管扣款类型，默认为SUBSCRIBE_DEDUCT。1.SUBSCRIBE_DEDUCT：托管模式（支付宝自动扣款，默认）；2.MERCHANT_DEDUCT：非托管模式（商户自助扣款）
        /// </summary>
        [XmlElement("deduct_type")]
        public string DeductType { get; set; }

        /// <summary>
        /// 订阅生效的类型，枚举值：IMMEDIATE_EFFECTIVE（默认）。传入 SCHEDULED_EFFECTIVE 时表示「订阅预约生效模式」
        /// </summary>
        [XmlElement("effective_type")]
        public string EffectiveType { get; set; }

        /// <summary>
        /// 扩展参数，用于订阅特殊能力的传参，使用方式详见具体场景接入指南
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("subscription_item")]
        public List<SubscriptionItem> Items { get; set; }

        /// <summary>
        /// 商户可通过此字段进行订阅信息的自定义传参，订阅生效后不可修改，将在全链路通知或查询中返回
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 支付金额，单位分； 仅用于商户自定义金额，若传了该值，用户实际支付金额会以该值为准
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 若为「单笔升级连续订阅」，必填。周期订阅正式生效的时间，格式 yyyy-MM-dd。 月维度下，订阅到期时间，统一按照23:59:59进行默认处理。
        /// </summary>
        [XmlElement("scheduled_effective_time")]
        public string ScheduledEffectiveTime { get; set; }

        /// <summary>
        /// 订单标题，若无特殊需求，无需使用该字段，默认使用商品名称
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }

        /// <summary>
        /// 用于签约页展示，若不传该字段，则展示默认文案。 低价试用场景文案："{pay_amount}元试用{trial_period_days}天"；免费试用场景文案："免费试用{trial_period_days}天
        /// </summary>
        [XmlElement("trial_desc")]
        public string TrialDesc { get; set; }

        /// <summary>
        /// 试用期天数：试用期天数设置为正整数，通常建议试用期天数3-7天
        /// </summary>
        [XmlElement("trial_period_days")]
        public long TrialPeriodDays { get; set; }
    }
}
