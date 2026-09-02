using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionSubmodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionSubmodeModifyModel : AopObject
    {
        /// <summary>
        /// 是否在周期结束时取消，仅用于取消/取消后恢复订阅：CANCEL传true表示周期末取消，传false表示立即取消并发起退款；REVERT_CANCEL需传false
        /// </summary>
        [XmlElement("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 客户创建接口返回的客户唯一标识
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 更新描述，若无特殊需求无需使用
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展参数，用于订阅特殊能力的传参，使用方式详见具体场景接入指南
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("subscription_submode_item")]
        public List<SubscriptionSubmodeItem> Items { get; set; }

        /// <summary>
        /// UPGRADE-升级，DOWNGRADE-降级，CANCEL-取消，REVERT_CANCEL-取消后恢复；不传视为UPGRADE。Submode不支持INCREASE_QUANTITY/DECREASE_QUANTITY，容量变化请提交完整价格商品对象并使用UPGRADE/DOWNGRADE
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 升级自定义支付金额，单位分；仅UPGRADE场景有效，不传时按price_data.unit_amount计算差价，传入时不能小于0，与coupon_id互斥
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 是否保持计费周期不变，当前仅用于升级场景：true-周期不变，false-重置周期
        /// </summary>
        [XmlElement("preserve_billing_cycle")]
        public bool PreserveBillingCycle { get; set; }

        /// <summary>
        /// 自定义退款金额，单位分；仅CANCEL立即取消(cancel_at_period_end=false)场景可传，不传时系统按时间规则计算残值，传入0表示直接取消不退款
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 订单标题，若无特殊需求无需使用，默认使用商品名称
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }

        /// <summary>
        /// 订阅ID，订阅唯一标识
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
