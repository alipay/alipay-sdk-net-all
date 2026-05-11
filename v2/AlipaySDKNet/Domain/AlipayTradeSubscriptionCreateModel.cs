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
        /// 用于自定义展示购买时的标题，若不传，默认使用商品名称作为标题
        /// </summary>
        [XmlElement("subscribe_title")]
        public string SubscribeTitle { get; set; }
    }
}
