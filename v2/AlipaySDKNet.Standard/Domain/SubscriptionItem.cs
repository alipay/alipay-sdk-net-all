using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionItem : AopObject
    {
        /// <summary>
        /// 订阅生效后，查询接口（alipay.trade.subscription.query）或通知接口（alipay.trade.subscription.changed）返回的item_id，使用方式详见具体场景接入指南。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 价格创建接口（alipay.trade.price.create）返回的价格id，代表本次操作的目标价格信息，使用方式详见具体场景接入指南。
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 购买的商品数量，目前仅在订阅创建（alipay.trade.subscription.create）场景按需传入该参数，使用方式详见具体场景接入指南。
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 目前仅用于订阅修改（alipay.trade.subscription.modify）场景下指定当前已生效的订阅项中商品的数量，使用方式详见具体场景接入指南。
        /// </summary>
        [XmlElement("source_quantity")]
        public string SourceQuantity { get; set; }

        /// <summary>
        /// 目前仅用于订阅修改（alipay.trade.subscription.modify）场景下指定订阅项的目标商品数量，使用方式详见具体场景接入指南。
        /// </summary>
        [XmlElement("target_quantity")]
        public string TargetQuantity { get; set; }
    }
}
