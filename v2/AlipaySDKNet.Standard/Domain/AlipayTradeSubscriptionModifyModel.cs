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
        /// 周期结束失效标识，仅用于取消/取消后恢复订阅，其他场景无需使用。 true：当前周期结束后 取消 false：取消后恢复，具体使用方式详见接入指南。
        /// </summary>
        [XmlElement("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// 更新描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("subscription_item")]
        public List<SubscriptionItem> Items { get; set; }

        /// <summary>
        /// UPGRADE：升级，DOWNGRADE：降级， 取消：CANCEL， 取消后恢复：REVERT_CANCEL，INCREASE_QUANTITY-商品数量扩容，DECREASE_QUANTITY-商品数量缩容，如若不传则视为UPGRADE，具体使用方式详见接入指南。 
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
        /// 订单标题
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }

        /// <summary>
        /// 订阅id
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
