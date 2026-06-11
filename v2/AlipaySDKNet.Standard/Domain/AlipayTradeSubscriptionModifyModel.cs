using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionModifyModel : AopObject
    {
        /// <summary>
        /// 是否在周期结束时取消，仅用于取消/取消后恢复订阅，其他场景无需使用。 true：CANCEL场景下传true表示在当前计费周期结束后取消订阅； false：CANCEL场景传false表示立即取消并发起退款，REVERT_CANCEL场景下需传false；具体使用方式详见接入指南。
        /// </summary>
        [XmlElement("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 更新描述，若无特殊需求，无需使用该字段
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
        [XmlArrayItem("subscription_item")]
        public List<SubscriptionItem> Items { get; set; }

        /// <summary>
        /// UPGRADE：升级，DOWNGRADE：降级， 取消：CANCEL， 取消后恢复：REVERT_CANCEL，INCREASE_QUANTITY-席位商品数量扩容，DECREASE_QUANTITY-席位商品数量缩容，如若不传则视为UPGRADE，具体使用方式详见接入指南。 
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 支付金额，单位分； 仅用于商户自定义金额，若传了该值，用户实际支付金额会以该值为准，目前仅用于普通订阅升级场景，具体使用方式详见接入指南。
        /// </summary>
        [XmlElement("pay_amount")]
        public long PayAmount { get; set; }

        /// <summary>
        /// 是否保持计费周期不变，当前仅用于升级场景 true：周期不变 false：重置周期，具体使用方式详见接入指南。
        /// </summary>
        [XmlElement("preserve_billing_cycle")]
        public bool PreserveBillingCycle { get; set; }

        /// <summary>
        /// 取消并退款场景下使用： 不传: 系统按照时间规则计算残值作为退款金额; 自定义传入: 按商家指定的金额退款，0表示直接取消不退款;
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 订单标题，若无特殊需求，无需使用该字段，默认使用商品名称
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }

        /// <summary>
        /// 订阅id，订阅唯一标识
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
