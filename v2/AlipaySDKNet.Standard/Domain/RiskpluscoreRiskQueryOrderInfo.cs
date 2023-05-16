using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskpluscoreRiskQueryOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskpluscoreRiskQueryOrderInfo : AopObject
    {
        /// <summary>
        /// 订单商品名称
        /// </summary>
        [XmlElement("order_items_name")]
        public string OrderItemsName { get; set; }

        /// <summary>
        /// 订单商品价格
        /// </summary>
        [XmlElement("order_items_price")]
        public string OrderItemsPrice { get; set; }

        /// <summary>
        /// 订单商品数量
        /// </summary>
        [XmlElement("order_items_quantity")]
        public string OrderItemsQuantity { get; set; }
    }
}
