using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionSubmodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionSubmodeCreateModel : AopObject
    {
        /// <summary>
        /// 客户创建接口返回的客户唯一标识
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 扣款模式：SUBSCRIBE_DEDUCT-支付宝托管扣款，MERCHANT_DEDUCT-商户主动扣款；不传默认为SUBSCRIBE_DEDUCT，试用期订阅不支持MERCHANT_DEDUCT
        /// </summary>
        [XmlElement("deduct_type")]
        public string DeductType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("subscription_submode_item")]
        public List<SubscriptionSubmodeItem> Items { get; set; }

        /// <summary>
        /// 订阅扩展元数据，必须为JSON object字符串，且value必须为字符串
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 首笔支付金额，单位分；不传时按price_data.unit_amount计算，允许传0，0元时进入仅签约链路，负数不允许
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 试用期描述，用于签约页展示
        /// </summary>
        [XmlElement("trial_desc")]
        public string TrialDesc { get; set; }

        /// <summary>
        /// 试用期天数，取值范围3-365；若同时传price_data.recurring.trial_period_days，两者必须一致
        /// </summary>
        [XmlElement("trial_period_days")]
        public long TrialPeriodDays { get; set; }
    }
}
